using employee_accounting.Data.Services;
using employee_accounting.Models.db;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.ComponentModel;

namespace employee_accounting
{
    public partial class MainForm : Form
    {
        private IWorkerService _workerService;
        private AppDbContext dbContext;
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.Database.EnsureCreated();
            this.dbContext.WorkersData.Load();
            this.dataGridView1.DataSource = dbContext.WorkersData.Local.ToBindingList();
            //MessageBox.Show(_workerService.GetByIdAsync(1).Result.Email);
            DataGridViewButtonColumn deleteEmployee = new DataGridViewButtonColumn();
            deleteEmployee.Name = "Удалить сотрудника";
            deleteEmployee.Text = "Удалить";
            deleteEmployee.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteEmployee);
            dataGridView1.Margin = new Padding(10);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Удалить сотрудника"].Index)
            {

                MessageBox.Show($"Ряд {e.RowIndex}, Столбец {e.ColumnIndex}");
            }
        }
    }
}