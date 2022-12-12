using employee_accounting.Models.db;
namespace employee_accounting
{
    public partial class Form1 : Form
    {
        public Form1()
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
                    dataGridView1.DataSource = workersData.ToList();
                }
                else
                {
                    MessageBox.Show("No records");
                    dataGridView1.DataSource=null; 
                }
            }
        }
    }
}