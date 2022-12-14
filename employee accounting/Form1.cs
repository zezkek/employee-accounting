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
        }
        private void RefreshDatagrid(DataGridView data)
        {
            var mainData = dbContext.WorkersData.Local.ToBindingList().Join(dbContext.SubDivisions.Local.ToBindingList(),
                w => w.IdSubDivision, s => s.Id, (w, s) => new
                {
                    Name = w.Name,
                    EmployeeNumber = w.EmployeeNumber,
                    JobTitle = w.JobTitle,
                    SubDiv = s.SubDivisionName,
                    Email = w.Email,
                    Phone = w.PhoneNumber,
                    Employ = w.EmploymentDate,
                    Dissmiss = w.DismissalDate,
                    State = w.State,
                    Id = w.Id
                }).ToList();
            data.DataSource= mainData;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectSearchType.Items.Add("По имени");
            selectSearchType.Items.Add("По табельному номеру");
            selectSearchType.Items.Add("По идентификатору");
            dbContext = new AppDbContext();
            dbContext.Database.EnsureCreated();
            dbContext.WorkersData.Load();
            List<string> itemsBox= new List<string>();
            foreach (var worker in dbContext.SubDivisions)
            {
                if (!itemsBox.Contains(worker.SubDivisionName.Normalize()))
                {
                    subFilter.Items.Add(worker.SubDivisionName.Normalize());
                    itemsBox.Add(worker.SubDivisionName.Normalize());
                }
            }
            subFilter.Items.Add("Без фильтра");
            subFilter.SelectedIndex=subFilter.Items.Count-1;

            //Объединение двух таблиц для вывода общего вида
            RefreshDatagrid(dataGridView1);
            dataGridView1.Columns[0].HeaderText = "Имя";
            dataGridView1.Columns[1].HeaderText = "Табельный номер";
            dataGridView1.Columns[2].HeaderText = "Должность";
            dataGridView1.Columns[3].HeaderText = "Подразделение";
            dataGridView1.Columns[4].HeaderText = "Почта";
            dataGridView1.Columns[5].HeaderText = "Телефон";
            dataGridView1.Columns[6].HeaderText = "Дата приёма";
            dataGridView1.Columns[7].HeaderText = "Дата увольнения";
            dataGridView1.Columns[8].HeaderText = "Состояние записи";

            //Добавление столбиков с кнопкой удаления и увольнения сотрудника

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
                int idDelete = (int)dataGridView1.Rows[e.RowIndex].Cells[9].Value;
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
                
                try
                {
                    int idDismis = (int)dataGridView1.Rows[e.RowIndex].Cells[9].Value;
                    if (string.IsNullOrEmpty(dbContext.WorkersData.Local.FirstOrDefault(w => w.Id == idDismis).DismissalDate.ToString()))
                    {
                        dbContext.WorkersData.Local.FirstOrDefault(w => w.Id == idDismis).DismissalDate = DateTime.Today;
                        dbContext.WorkersData.Local.FirstOrDefault(w => w.Id == idDismis).State = false;
                        RefreshDatagrid(dataGridView1);
                    }
                    else
                        MessageBox.Show("Сотрудник уже был уволен");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Не удалось обновить таблицу, сперва её нужно сохранить");
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
            AddEmployee ad= new AddEmployee(this, dbContext, dataGridView1);
            ad.Show();
        }

        private void searchByNameText_TextChanged(object sender, EventArgs e)
        {
            var mainData = dbContext.WorkersData.Local.ToBindingList().Join(dbContext.SubDivisions.Local.ToBindingList(),
                w => w.IdSubDivision, s => s.Id, (w, s) => new
                {
                    Name = w.Name,
                    EmployeeNumber = w.EmployeeNumber,
                    JobTitle = w.JobTitle,
                    SubDiv = s.SubDivisionName,
                    Email = w.Email,
                    Phone = w.PhoneNumber,
                    Employ = w.EmploymentDate,
                    Dissmiss = w.DismissalDate,
                    State = w.State,
                    Id = w.Id
                }).ToList();
            switch (selectSearchType.SelectedItem)
            {
                case "По имени":
                    dataGridView1.DataSource = mainData.Where(w => w.Name.Contains(searchText.Text)).ToList();
                    dataGridView1.Refresh();
                    break;
                case "По табельному номеру":
                    dataGridView1.DataSource = mainData.Where(w => w.EmployeeNumber.ToString().Contains(searchText.Text)).ToList();
                    dataGridView1.Refresh();
                    break;
                case "По идентификатору":
                    dataGridView1.DataSource = mainData.Where(w => w.Id.ToString().Equals(searchText.Text)).ToList();
                    dataGridView1.Refresh();
                    break;
                default:
                    MessageBox.Show("Необходимо выбрать тип поиска");
                    break;
            }
        }

        private void subFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mainData = dbContext.WorkersData.Local.ToBindingList().Join(dbContext.SubDivisions.Local.ToBindingList(),
                w => w.IdSubDivision, s => s.Id, (w, s) => new
                {
                    Name = w.Name,
                    EmployeeNumber = w.EmployeeNumber,
                    JobTitle = w.JobTitle,
                    SubDiv = s.SubDivisionName,
                    Email = w.Email,
                    Phone = w.PhoneNumber,
                    Employ = w.EmploymentDate,
                    Dissmiss = w.DismissalDate,
                    State = w.State,
                    Id = w.Id
                }).ToList();
            if (subFilter.SelectedItem != "Без фильтра")
            {
                dataGridView1.DataSource = mainData.Where(w => w.SubDiv.Contains(subFilter.SelectedItem.ToString())).ToList();
                dataGridView1.Refresh();
            }
            else
            {
                dataGridView1.DataSource = dbContext.WorkersData.ToList();
                dataGridView1.Refresh();
            }
        }

        private void employeeDir_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubDivisionDirectory em=new SubDivisionDirectory(this, dbContext);
            em.Show();
        }
    }
}