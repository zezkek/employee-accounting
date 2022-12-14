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
    public partial class SubDivisionDirectory : Form
    {
        private MainForm mainForm;
        private AppDbContext _context;
        public SubDivisionDirectory(MainForm mf, AppDbContext db)
        {
            InitializeComponent();
            mainForm = mf;
            _context = db;
        }
        List<string> workersBysubD = new List<string>();
        string bubble = string.Empty;
        private void SubDivisionDirectory_Load(object sender, EventArgs e)
        {
            foreach (SubDivision subs in _context.SubDivisions.Local)
            {
                foreach (WorkersData worker in _context.WorkersData.Local.Where(w => w.IdSubDivision == subs.Id))
                {
                    bubble=string.Join(' ', bubble, worker.Id.ToString());
                }
                workersBysubD.Add(bubble);
                bubble=string.Empty;
            }
                dataGridView1.DataSource = _context.SubDivisions.Local.ToBindingList().Select(
                    c => new
                    {
                        c.Id,
                        c.SubDivisionName,
                        c.HeadEmployee.Name,
                        c.State,
                    }).ToList();
                dataGridView1.Columns[1].HeaderText = "Название подразделения";
                dataGridView1.Columns[2].HeaderText = "Руководитель";
                dataGridView1.Columns[3].HeaderText = "Состояние записи";
            //dataGridView1.Columns[4].HeaderText = "Сотрудники";
            //dataGridView1.DataSource = dbContext.SubDivisions.Local.ToList().Select(column => column.SubDivisionName);
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewColumn state = new DataGridViewColumn()
            {
                Name = "Сотрудники",
                ValueType = typeof(string),
                CellTemplate = cell,
            };
            dataGridView1.Columns.Add(state);
            int key = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[4].Value = workersBysubD[key];
                key++;
            }
;
            DataGridViewButtonColumn deleteSubD = new DataGridViewButtonColumn();
            deleteSubD.Name = "Удалить запись";
            deleteSubD.Text = "Удалить";
            deleteSubD.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteSubD);
        }
        private void SubDivisionDirectory_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void addSubD_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSubD subD = new AddSubD(_context, this);
            subD.Show();
        }

        private void SubDivisionDirectory_Shown(object sender, EventArgs e)
        {
            this.Refresh();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Удалить запись"].Index)
            {
                int idDelete = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                try
                {
                    _context.SubDivisions.Remove(_context.SubDivisions.FirstOrDefault(w => w.Id == idDelete));
                    _context.SaveChanges();
                    this.Close();
                    SubDivisionDirectory subs = new SubDivisionDirectory(mainForm, _context);
                    subs.Show();
                }
                catch (Exception ex)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var data = _context.SubDivisions.Local.ToBindingList().Select(
                    c => new
                    {
                        c.Id,
                        c.SubDivisionName,
                        c.HeadEmployee.Name,
                        c.State,
                    }).ToList();
            dataGridView1.DataSource = data.Where(w => w.Id.ToString().Contains(textToSearch.Text)).ToList();
            dataGridView1.Refresh();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }
    }
}
