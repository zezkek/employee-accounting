using employee_accounting.Models.db;
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
    public partial class AddSubD : Form
    {
        private AppDbContext app;
        private SubDivisionDirectory sb;
        public AddSubD(AppDbContext app, SubDivisionDirectory sb)
        {
            InitializeComponent();
            this.app = app;
            this.sb = sb;

        }

        private void addSubButton_Click(object sender, EventArgs e)
        {
            SubDivision newSub = new SubDivision()
            {
                SubDivisionName = nameSubDText.Text,
                HeadEmployeeId = int.Parse(idHeadSubText.Text),
                State = true,
            };
            app.SubDivisions.Add(newSub);
            app.SaveChanges();
            this.Close();
            sb.Show();
        }
    }
}
