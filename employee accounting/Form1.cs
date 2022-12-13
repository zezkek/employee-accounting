using employee_accounting.Models.db;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;

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
            selectSearchType.Items.Add("По имени");
            selectSearchType.Items.Add("По табельному номеру");
            dbContext = new AppDbContext();
            dbContext.Database.EnsureCreated();
            dbContext.WorkersData.Load();
            dataGridView1.DataSource = dbContext.WorkersData.Local.ToBindingList();
            DataGridViewButtonColumn dissmisEmployee = new DataGridViewButtonColumn();
            dissmisEmployee.Name = "Уволить сотрудника";
            dissmisEmployee.Text = "Уволить";
            dissmisEmployee.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(dissmisEmployee);
            DataGridViewButtonColumn deleteEmployee = new DataGridViewButtonColumn();
            deleteEmployee.Name = "Удалить запись";
            deleteEmployee.Text = "Удалить";
            deleteEmployee.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteEmployee);
            dataGridView1.Margin = new Padding(10);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Удалить запись"].Index)
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
            if (e.ColumnIndex == dataGridView1.Columns["Уволить сотрудника"].Index)
            {
                int idDismis = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                try
                {
                    if (string.IsNullOrEmpty(dbContext.WorkersData.Local.FirstOrDefault(w => w.Id == idDismis).DismissalDate.ToString()))
                        dbContext.WorkersData.Local.FirstOrDefault(w => w.Id == idDismis).DismissalDate = DateTime.Today;
                    else
                        MessageBox.Show("Сотрудник уже был уволен");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Не удалось обновить таблицу " + ex.Message);
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

        private void searchByNameText_TextChanged(object sender, EventArgs e)
        {
            switch (selectSearchType.SelectedItem)
            {
                case "По имени":
                    dataGridView1.DataSource = dbContext.WorkersData.Where(w => w.Name.Contains(searchText.Text)).ToList();
                    dataGridView1.Refresh();
                    break;
                case "По табельному номеру":
                    dataGridView1.DataSource = dbContext.WorkersData.Where(w => w.EmployeeNumber.ToString().Contains(searchText.Text)).ToList();
                    dataGridView1.Refresh();
                    break;
                default:
                    MessageBox.Show("Необходимо выбрать тип поиска");
                    break;
            }
        }
    }
}