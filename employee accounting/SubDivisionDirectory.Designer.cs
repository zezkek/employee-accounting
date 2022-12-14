namespace employee_accounting
{
    partial class SubDivisionDirectory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addSubD = new System.Windows.Forms.Button();
            this.saveChangesSub = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.textToSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // addSubD
            // 
            this.addSubD.Location = new System.Drawing.Point(12, 12);
            this.addSubD.Name = "addSubD";
            this.addSubD.Size = new System.Drawing.Size(156, 23);
            this.addSubD.TabIndex = 1;
            this.addSubD.Text = "Добавить подразделение";
            this.addSubD.UseVisualStyleBackColor = true;
            this.addSubD.Click += new System.EventHandler(this.addSubD_Click);
            // 
            // saveChangesSub
            // 
            this.saveChangesSub.Location = new System.Drawing.Point(898, 12);
            this.saveChangesSub.Name = "saveChangesSub";
            this.saveChangesSub.Size = new System.Drawing.Size(156, 23);
            this.saveChangesSub.TabIndex = 2;
            this.saveChangesSub.Text = "Сохранить изменения";
            this.saveChangesSub.UseVisualStyleBackColor = true;
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(817, 12);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 23);
            this.goBack.TabIndex = 3;
            this.goBack.Text = "Назад";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // textToSearch
            // 
            this.textToSearch.Location = new System.Drawing.Point(190, 25);
            this.textToSearch.Name = "textToSearch";
            this.textToSearch.Size = new System.Drawing.Size(100, 23);
            this.textToSearch.TabIndex = 4;
            this.textToSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск по идентификатору";
            // 
            // SubDivisionDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textToSearch);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.saveChangesSub);
            this.Controls.Add(this.addSubD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SubDivisionDirectory";
            this.Text = "SubDivisionDirectory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubDivisionDirectory_FormClosing);
            this.Load += new System.EventHandler(this.SubDivisionDirectory_Load);
            this.Shown += new System.EventHandler(this.SubDivisionDirectory_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button addSubD;
        private Button saveChangesSub;
        private Button goBack;
        private TextBox textToSearch;
        private Label label1;
    }
}