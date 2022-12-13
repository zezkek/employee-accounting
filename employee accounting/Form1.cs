using employee_accounting.Models.db;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace employee_accounting
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            using WorkersContext db = new WorkersContext();
            var workersData = from d in db.WorkersData select d;
            if (workersData != null)
            {

                if (workersData.Count() > 0)
                {
                    List<WorkersData> workersList = workersData.ToList();
                    dataGridView1.DataSource = workersData.ToList();
                }
                else
                {
                    MessageBox.Show("No records");
                    dataGridView1.DataSource = null;
                }
            }
            DataGridViewButtonColumn deleteEmployee=new DataGridViewButtonColumn();
            deleteEmployee.Name= "Удалить сотрудника";
            deleteEmployee.Text = "Удалить";
            deleteEmployee.UseColumnTextForButtonValue= true;
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