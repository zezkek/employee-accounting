namespace employee_accounting
{
    partial class EmployeeDirectory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.workersDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDivisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dismissalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // workersDataBindingSource
            // 
            this.workersDataBindingSource.DataSource = typeof(employee_accounting.Models.db.WorkersData);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.employeeNumberDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.subDivisionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.employmentDateDataGridViewTextBoxColumn,
            this.dismissalDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workersDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(967, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // employeeNumberDataGridViewTextBoxColumn
            // 
            this.employeeNumberDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNumber";
            this.employeeNumberDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
            this.employeeNumberDataGridViewTextBoxColumn.Name = "employeeNumberDataGridViewTextBoxColumn";
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            // 
            // subDivisionDataGridViewTextBoxColumn
            // 
            this.subDivisionDataGridViewTextBoxColumn.DataPropertyName = "SubDivision";
            this.subDivisionDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.subDivisionDataGridViewTextBoxColumn.Name = "subDivisionDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // employmentDateDataGridViewTextBoxColumn
            // 
            this.employmentDateDataGridViewTextBoxColumn.DataPropertyName = "EmploymentDate";
            this.employmentDateDataGridViewTextBoxColumn.HeaderText = "Дата приёма";
            this.employmentDateDataGridViewTextBoxColumn.Name = "employmentDateDataGridViewTextBoxColumn";
            // 
            // dismissalDateDataGridViewTextBoxColumn
            // 
            this.dismissalDateDataGridViewTextBoxColumn.DataPropertyName = "DismissalDate";
            this.dismissalDateDataGridViewTextBoxColumn.HeaderText = "Дата увольнения";
            this.dismissalDateDataGridViewTextBoxColumn.Name = "dismissalDateDataGridViewTextBoxColumn";
            // 
            // EmployeeDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeDirectory";
            this.Text = "EmployeeDirectory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeDirectory_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeDirectory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workersDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource workersDataBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subDivisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employmentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dismissalDateDataGridViewTextBoxColumn;
    }
}