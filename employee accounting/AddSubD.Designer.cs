namespace employee_accounting
{
    partial class AddSubD
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
            this.nameSubDText = new System.Windows.Forms.TextBox();
            this.idHeadSubText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addSubButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameSubDText
            // 
            this.nameSubDText.Location = new System.Drawing.Point(29, 27);
            this.nameSubDText.Name = "nameSubDText";
            this.nameSubDText.Size = new System.Drawing.Size(145, 23);
            this.nameSubDText.TabIndex = 0;
            // 
            // idHeadSubText
            // 
            this.idHeadSubText.Location = new System.Drawing.Point(46, 96);
            this.idHeadSubText.Name = "idHeadSubText";
            this.idHeadSubText.Size = new System.Drawing.Size(100, 23);
            this.idHeadSubText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название подразделения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Идентификатор руководителя";
            // 
            // addSubButton
            // 
            this.addSubButton.Location = new System.Drawing.Point(236, 52);
            this.addSubButton.Name = "addSubButton";
            this.addSubButton.Size = new System.Drawing.Size(75, 23);
            this.addSubButton.TabIndex = 4;
            this.addSubButton.Text = "Добавить";
            this.addSubButton.UseVisualStyleBackColor = true;
            this.addSubButton.Click += new System.EventHandler(this.addSubButton_Click);
            // 
            // AddSubD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 131);
            this.Controls.Add(this.addSubButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idHeadSubText);
            this.Controls.Add(this.nameSubDText);
            this.Name = "AddSubD";
            this.Text = "AddSubD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameSubDText;
        private TextBox idHeadSubText;
        private Label label1;
        private Label label2;
        private Button addSubButton;
    }
}