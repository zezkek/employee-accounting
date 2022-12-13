using employee_accounting.Models.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_accounting
{
    public partial class EmployeeDirectory : Form
    {
        private MainForm mf;
        private DbSet<WorkersData> workers;
        private enum accountState
        {
            Закрытая = 0,
            Действующая
        }
        public EmployeeDirectory(MainForm mf, DbSet<WorkersData> wk)
        {
            InitializeComponent();
            this.mf = mf;
            workers = wk; 
        }

        private void EmployeeDirectory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = workers.Local.ToBindingList();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewColumn state = new DataGridViewColumn()
            {
                Name = "Состояние записи",
                ValueType = typeof(accountState),
                CellTemplate = cell,
            };
            dataGridView1.Columns.Add(state);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[7].Value==null)
                    row.Cells[8].Value = 1;
                else
                    row.Cells[8].Value = 0;
            }
        }

        private void EmployeeDirectory_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.Show();
        }
    }
}
