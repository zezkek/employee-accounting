namespace employee_accounting
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ShowEmployeBtn = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDivisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dismissalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowEmployeBtn
            // 
            this.ShowEmployeBtn.Location = new System.Drawing.Point(12, 12);
            this.ShowEmployeBtn.Name = "ShowEmployeBtn";
            this.ShowEmployeBtn.Size = new System.Drawing.Size(205, 23);
            this.ShowEmployeBtn.TabIndex = 0;
            this.ShowEmployeBtn.Text = "Показать список сотрудников";
            this.ShowEmployeBtn.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(223, 12);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(143, 23);
            this.AddEmployee.TabIndex = 1;
            this.AddEmployee.Text = "Добавить сотрудника";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.employeeNumberDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.subDivisionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.employmentDateDataGridViewTextBoxColumn,
            this.dismissalDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workersDataBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1403, 380);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 42;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 56;
            // 
            // employeeNumberDataGridViewTextBoxColumn
            // 
            this.employeeNumberDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNumber";
            this.employeeNumberDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
            this.employeeNumberDataGridViewTextBoxColumn.Name = "employeeNumberDataGridViewTextBoxColumn";
            this.employeeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeNumberDataGridViewTextBoxColumn.Width = 121;
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            this.jobTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobTitleDataGridViewTextBoxColumn.Width = 94;
            // 
            // subDivisionDataGridViewTextBoxColumn
            // 
            this.subDivisionDataGridViewTextBoxColumn.DataPropertyName = "SubDivision";
            this.subDivisionDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.subDivisionDataGridViewTextBoxColumn.Name = "subDivisionDataGridViewTextBoxColumn";
            this.subDivisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.subDivisionDataGridViewTextBoxColumn.Width = 117;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 66;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 115;
            // 
            // employmentDateDataGridViewTextBoxColumn
            // 
            this.employmentDateDataGridViewTextBoxColumn.DataPropertyName = "EmploymentDate";
            this.employmentDateDataGridViewTextBoxColumn.HeaderText = "Дата приёма";
            this.employmentDateDataGridViewTextBoxColumn.Name = "employmentDateDataGridViewTextBoxColumn";
            this.employmentDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.employmentDateDataGridViewTextBoxColumn.Width = 94;
            // 
            // dismissalDateDataGridViewTextBoxColumn
            // 
            this.dismissalDateDataGridViewTextBoxColumn.DataPropertyName = "DismissalDate";
            this.dismissalDateDataGridViewTextBoxColumn.HeaderText = "Дата увольнения";
            this.dismissalDateDataGridViewTextBoxColumn.Name = "dismissalDateDataGridViewTextBoxColumn";
            this.dismissalDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dismissalDateDataGridViewTextBoxColumn.Width = 115;
            // 
            // workersDataBindingSource
            // 
            this.workersDataBindingSource.DataSource = typeof(employee_accounting.Models.db.WorkersData);
            // 
            // workersDataBindingSource1
            // 
            this.workersDataBindingSource1.DataSource = typeof(employee_accounting.Models.db.WorkersData);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(1267, 12);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(148, 23);
            this.SaveChanges.TabIndex = 3;
            this.SaveChanges.Text = "Сохранить изменения";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1427, 501);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.ShowEmployeBtn);
            this.Name = "MainForm";
            this.Text = "Учет сотрудников";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ShowEmployeBtn;
        private Button AddEmployee;
        private DataGridView dataGridView1;
        private BindingSource workersDataBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subDivisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employmentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dismissalDateDataGridViewTextBoxColumn;
        private BindingSource workersDataBindingSource1;
        private Button SaveChanges;
    }
}