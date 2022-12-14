namespace employee_accounting
{
    partial class AddEmployee
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
            this.phoneText = new System.Windows.Forms.Label();
            this.mailText = new System.Windows.Forms.Label();
            this.subText = new System.Windows.Forms.Label();
            this.numberText = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.mailInput = new System.Windows.Forms.TextBox();
            this.subdInput = new System.Windows.Forms.TextBox();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.errorValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.jobInput = new System.Windows.Forms.TextBox();
            this.jobTitleText = new System.Windows.Forms.Label();
            this.emplText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneText
            // 
            this.phoneText.AutoSize = true;
            this.phoneText.Location = new System.Drawing.Point(203, 93);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(101, 15);
            this.phoneText.TabIndex = 29;
            this.phoneText.Text = "Номер телефона";
            // 
            // mailText
            // 
            this.mailText.AutoSize = true;
            this.mailText.Location = new System.Drawing.Point(68, 93);
            this.mailText.Name = "mailText";
            this.mailText.Size = new System.Drawing.Size(41, 15);
            this.mailText.TabIndex = 28;
            this.mailText.Text = "Почта";
            // 
            // subText
            // 
            this.subText.AutoSize = true;
            this.subText.Location = new System.Drawing.Point(532, 44);
            this.subText.Name = "subText";
            this.subText.Size = new System.Drawing.Size(92, 15);
            this.subText.TabIndex = 27;
            this.subText.Text = "Подразделение";
            // 
            // numberText
            // 
            this.numberText.AutoSize = true;
            this.numberText.Location = new System.Drawing.Point(247, 44);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(107, 15);
            this.numberText.TabIndex = 26;
            this.numberText.Text = "Табельный номер";
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Location = new System.Drawing.Point(95, 44);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(34, 15);
            this.nameText.TabIndex = 25;
            this.nameText.Text = "ФИО";
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(179, 111);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(149, 23);
            this.phoneInput.TabIndex = 22;
            this.phoneInput.Validating += new System.ComponentModel.CancelEventHandler(this.phoneInput_Validating);
            // 
            // mailInput
            // 
            this.mailInput.Location = new System.Drawing.Point(12, 111);
            this.mailInput.Name = "mailInput";
            this.mailInput.Size = new System.Drawing.Size(161, 23);
            this.mailInput.TabIndex = 21;
            this.mailInput.Validating += new System.ComponentModel.CancelEventHandler(this.mailInput_Validating);
            // 
            // subdInput
            // 
            this.subdInput.Location = new System.Drawing.Point(494, 62);
            this.subdInput.Name = "subdInput";
            this.subdInput.Size = new System.Drawing.Size(169, 23);
            this.subdInput.TabIndex = 20;
            this.subdInput.Validating += new System.ComponentModel.CancelEventHandler(this.subdInput_Validating);
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(247, 62);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(107, 23);
            this.numberInput.TabIndex = 19;
            this.numberInput.Validating += new System.ComponentModel.CancelEventHandler(this.numberInput_Validating);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(4, 62);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(239, 23);
            this.nameInput.TabIndex = 18;
            this.nameInput.Validating += new System.ComponentModel.CancelEventHandler(this.nameInput_Validating);
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(334, 111);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(167, 23);
            this.dateInput.TabIndex = 32;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(532, 110);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(105, 23);
            this.AddEmployeeButton.TabIndex = 33;
            this.AddEmployeeButton.Text = "Добавить";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // errorValidator
            // 
            this.errorValidator.ContainerControl = this;
            // 
            // jobInput
            // 
            this.jobInput.Location = new System.Drawing.Point(360, 62);
            this.jobInput.Name = "jobInput";
            this.jobInput.Size = new System.Drawing.Size(128, 23);
            this.jobInput.TabIndex = 34;
            this.jobInput.Validating += new System.ComponentModel.CancelEventHandler(this.jobInput_Validating);
            // 
            // jobTitleText
            // 
            this.jobTitleText.AutoSize = true;
            this.jobTitleText.Location = new System.Drawing.Point(387, 44);
            this.jobTitleText.Name = "jobTitleText";
            this.jobTitleText.Size = new System.Drawing.Size(69, 15);
            this.jobTitleText.TabIndex = 35;
            this.jobTitleText.Text = "Должность";
            // 
            // emplText
            // 
            this.emplText.AutoSize = true;
            this.emplText.Location = new System.Drawing.Point(354, 93);
            this.emplText.Name = "emplText";
            this.emplText.Size = new System.Drawing.Size(134, 15);
            this.emplText.TabIndex = 30;
            this.emplText.Text = "Дата приёма на работу";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(666, 162);
            this.Controls.Add(this.jobTitleText);
            this.Controls.Add(this.jobInput);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.emplText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.mailText);
            this.Controls.Add(this.subText);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.mailInput);
            this.Controls.Add(this.subdInput);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.nameInput);
            this.Name = "AddEmployee";
            this.Text = "Добавление нового сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEmployee_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label phoneText;
        private Label mailText;
        private Label subText;
        private Label numberText;
        private Label nameText;
        private TextBox phoneInput;
        private TextBox mailInput;
        private TextBox subdInput;
        private TextBox numberInput;
        private TextBox nameInput;
        private DateTimePicker dateInput;
        private Button AddEmployeeButton;
        private ErrorProvider errorValidator;
        private Label jobTitleText;
        private TextBox jobInput;
        private Label emplText;
    }
}