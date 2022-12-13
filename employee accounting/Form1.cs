using employee_accounting.Models.db;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.ComponentModel;

namespace employee_accounting
{
    public partial class MainForm : Form
    {
        private AppDbContext dbContext;
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            dbContext?.Dispose();
            dbContext = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbContext = new AppDbContext();
            dbContext.Database.EnsureCreated();
            dbContext.WorkersData.Load();
            dataGridView1.DataSource = dbContext.WorkersData.Local.ToBindingList(); 
            DataGridViewButtonColumn deleteEmployee = new DataGridViewButtonColumn();
            deleteEmployee.Name = "������� ����������";
            deleteEmployee.Text = "�������";
            deleteEmployee.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteEmployee);
            dataGridView1.Margin = new Padding(10);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["������� ����������"].Index)
            {
                //rowindex++
                int idDelete = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                try
                {
                    dbContext.WorkersData.Remove(dbContext.WorkersData.FirstOrDefault(w => w.Id == idDelete));
                }
                catch(Exception ex)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            dbContext!.SaveChanges();
            dataGridView1.Refresh();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AddEmployee ad= new AddEmployee(this, dbContext.WorkersData);
            ad.Show();
        }
    }
}