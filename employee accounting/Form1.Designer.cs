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
            this.AddEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workersDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveChanges = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.selectSearchType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeDir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(12, 12);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1403, 380);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // workersDataBindingSource
            // 
            this.workersDataBindingSource.DataSource = typeof(employee_accounting.Models.db.WorkersData);
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
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(12, 466);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(393, 23);
            this.searchText.TabIndex = 4;
            this.searchText.TextChanged += new System.EventHandler(this.searchByNameText_TextChanged);
            // 
            // selectSearchType
            // 
            this.selectSearchType.FormattingEnabled = true;
            this.selectSearchType.Location = new System.Drawing.Point(12, 437);
            this.selectSearchType.Name = "selectSearchType";
            this.selectSearchType.Size = new System.Drawing.Size(211, 23);
            this.selectSearchType.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фильтр параметра";
            // 
            // subFilter
            // 
            this.subFilter.FormattingEnabled = true;
            this.subFilter.Location = new System.Drawing.Point(411, 466);
            this.subFilter.Name = "subFilter";
            this.subFilter.Size = new System.Drawing.Size(211, 23);
            this.subFilter.TabIndex = 10;
            this.subFilter.SelectedIndexChanged += new System.EventHandler(this.subFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Фильтр по подразделениям";
            // 
            // employeeDir
            // 
            this.employeeDir.Location = new System.Drawing.Point(932, 465);
            this.employeeDir.Name = "employeeDir";
            this.employeeDir.Size = new System.Drawing.Size(201, 23);
            this.employeeDir.TabIndex = 12;
            this.employeeDir.Text = "Справочник \"Подразделения\"";
            this.employeeDir.UseVisualStyleBackColor = true;
            this.employeeDir.Click += new System.EventHandler(this.employeeDir_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1427, 501);
            this.Controls.Add(this.employeeDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectSearchType);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddEmployee);
            this.Name = "MainForm";
            this.Text = "Учет сотрудников";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button AddEmployee;
        private DataGridView dataGridView1;
        private BindingSource workersDataBindingSource;
        private DataGridViewTextBoxColumn subDivisionDataGridViewTextBoxColumn;
        private Button SaveChanges;
        private TextBox searchText;
        private ComboBox selectSearchType;
        private Label label1;
        private ComboBox subFilter;
        private Label label2;
        private Button employeeDir;
    }
}