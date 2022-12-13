using employee_accounting.Models.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_accounting
{
    public partial class AddEmployee : Form
    {
        private MainForm mf;
        private DbSet<WorkersData> wk;

        public AddEmployee(MainForm mf, DbSet<WorkersData> wk)
        {
            InitializeComponent();
            this.mf = mf;
            this.wk = wk;
        }

        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            mf.Enabled = true;
        }
        private bool BasicValidator(TextBox txt, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                errorValidator.SetError(nameInput, "Поле не может быть пустым");
                return false;
            }
            else
                return true;
        }

        private void nameInput_Validating(object sender, CancelEventArgs e)
        {
            if (BasicValidator(nameInput, e))
            {
                e.Cancel = false;
                errorValidator.Clear();
            }
        }

        private void numberInput_Validating(object sender, CancelEventArgs e)
        {
            if (BasicValidator(numberInput, e))
            {
                if (!int.TryParse(numberInput.Text, out int number))
                {
                    e.Cancel = true;
                    numberInput.Focus();
                    errorValidator.SetError(numberInput, "Нужно ввести число");
                }
                else
                {
                    if (number > 0)
                    {
                        e.Cancel = false;
                        errorValidator.Clear();
                    }
                    else
                    {
                        e.Cancel = true;
                        numberInput.Focus();
                        errorValidator.SetError(numberInput, "Число должно быть положительным");
                    }
                }
            }
        }
        private void jobInput_Validating(object sender, CancelEventArgs e)
        {
            if (BasicValidator(jobInput, e))
            {
                e.Cancel = false;
                errorValidator.Clear();
            }
        }

        private void subdInput_Validating(object sender, CancelEventArgs e)
        {
            if (BasicValidator(subdInput, e))
            {
                e.Cancel = false;
                errorValidator.Clear();
            }
        }

        private void mailInput_Validating(object sender, CancelEventArgs e)
        {
            if (BasicValidator(mailInput, e))
            {
                Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");
                if (validateEmailRegex.IsMatch(mailInput.Text))
                {
                    e.Cancel = false;
                    errorValidator.Clear();
                }
                else
                {
                    e.Cancel = true;
                    mailInput.Focus();
                    errorValidator.SetError(mailInput, "Нужно ввести почту");
                }
            }
        }

        private void phoneInput_Validating(object sender, CancelEventArgs e)
        {
            if (BasicValidator(phoneInput, e))
            {
                //Regex validatePhoneNumberRegex = new Regex("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
                //if (validatePhoneNumberRegex.IsMatch(phoneInput.Text))
                //{
                //    e.Cancel = false;
                //}
                //else
                //{
                //    e.Cancel = true;
                //    phoneInput.Focus();
                //    errorValidator.SetError(phoneInput, "Некорректный формат номера");
                //}
                e.Cancel= false;
            }
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            if (!errorValidator.HasErrors)
            {
                WorkersData newWorker = new WorkersData()
                {
                    Name = nameInput.Text,
                    EmployeeNumber = int.Parse(numberInput.Text),
                    JobTitle = jobInput.Text,
                    SubDivision = subdInput.Text,
                    Email = mailInput.Text,
                    PhoneNumber = phoneInput.Text,
                    EmploymentDate = DateTime.Parse(dateInput.Value.ToShortDateString()),
                };
                wk.Add(newWorker);
                this.Close();
                mf.Enabled= true;
            }
        }
        
    }
}
