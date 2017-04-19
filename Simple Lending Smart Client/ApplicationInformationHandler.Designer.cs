namespace Simple_Lending_Smart_Client
{
    partial class ApplicationInformationHandler
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
            this.applicantInfo = new System.Windows.Forms.GroupBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberInput = new System.Windows.Forms.MaskedTextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.emailAddressInput = new System.Windows.Forms.TextBox();
            this.ssnInput = new System.Windows.Forms.MaskedTextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.employmentInfo = new System.Windows.Forms.GroupBox();
            this.incomeFrequencySelect = new System.Windows.Forms.ComboBox();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.isBranchEmployeeCheckbox = new System.Windows.Forms.CheckBox();
            this.incomeFrequencyLabel = new System.Windows.Forms.Label();
            this.employeeIDInput = new System.Windows.Forms.MaskedTextBox();
            this.incomeInput = new System.Windows.Forms.TextBox();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.employerLabel = new System.Windows.Forms.Label();
            this.employerInput = new System.Windows.Forms.TextBox();
            this.loanInfo = new System.Windows.Forms.GroupBox();
            this.termInput = new System.Windows.Forms.TextBox();
            this.termLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.completeButton = new System.Windows.Forms.Button();
            this.loanStatusDisplay = new System.Windows.Forms.TextBox();
            this.loanStatusLabel = new System.Windows.Forms.Label();
            this.manualDecisionButton = new System.Windows.Forms.Button();
            this.applicantInfo.SuspendLayout();
            this.employmentInfo.SuspendLayout();
            this.loanInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicantInfo
            // 
            this.applicantInfo.Controls.Add(this.emailAddressLabel);
            this.applicantInfo.Controls.Add(this.phoneNumberLabel);
            this.applicantInfo.Controls.Add(this.phoneNumberInput);
            this.applicantInfo.Controls.Add(this.ssnLabel);
            this.applicantInfo.Controls.Add(this.emailAddressInput);
            this.applicantInfo.Controls.Add(this.ssnInput);
            this.applicantInfo.Controls.Add(this.lastNameInput);
            this.applicantInfo.Controls.Add(this.lastNameLabel);
            this.applicantInfo.Controls.Add(this.firstNameLabel);
            this.applicantInfo.Controls.Add(this.firstNameInput);
            this.applicantInfo.Location = new System.Drawing.Point(12, 89);
            this.applicantInfo.Name = "applicantInfo";
            this.applicantInfo.Size = new System.Drawing.Size(544, 74);
            this.applicantInfo.TabIndex = 1;
            this.applicantInfo.TabStop = false;
            this.applicantInfo.Text = "Applicant Info";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(329, 18);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(73, 13);
            this.emailAddressLabel.TabIndex = 10;
            this.emailAddressLabel.Text = "Email Address";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(436, 19);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.TabIndex = 9;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // phoneNumberInput
            // 
            this.phoneNumberInput.Location = new System.Drawing.Point(436, 35);
            this.phoneNumberInput.Mask = "(999) 000-0000";
            this.phoneNumberInput.Name = "phoneNumberInput";
            this.phoneNumberInput.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberInput.TabIndex = 8;
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(222, 19);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(29, 13);
            this.ssnLabel.TabIndex = 7;
            this.ssnLabel.Text = "SSN";
            // 
            // emailAddressInput
            // 
            this.emailAddressInput.Location = new System.Drawing.Point(329, 35);
            this.emailAddressInput.Name = "emailAddressInput";
            this.emailAddressInput.Size = new System.Drawing.Size(100, 20);
            this.emailAddressInput.TabIndex = 5;
            // 
            // ssnInput
            // 
            this.ssnInput.Location = new System.Drawing.Point(222, 36);
            this.ssnInput.Mask = "000-00-0000";
            this.ssnInput.Name = "ssnInput";
            this.ssnInput.Size = new System.Drawing.Size(100, 20);
            this.ssnInput.TabIndex = 4;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(116, 36);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(100, 20);
            this.lastNameInput.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(113, 20);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(7, 20);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(6, 36);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(100, 20);
            this.firstNameInput.TabIndex = 0;
            // 
            // employmentInfo
            // 
            this.employmentInfo.Controls.Add(this.incomeFrequencySelect);
            this.employmentInfo.Controls.Add(this.employeeIDLabel);
            this.employmentInfo.Controls.Add(this.isBranchEmployeeCheckbox);
            this.employmentInfo.Controls.Add(this.incomeFrequencyLabel);
            this.employmentInfo.Controls.Add(this.employeeIDInput);
            this.employmentInfo.Controls.Add(this.incomeInput);
            this.employmentInfo.Controls.Add(this.incomeLabel);
            this.employmentInfo.Controls.Add(this.employerLabel);
            this.employmentInfo.Controls.Add(this.employerInput);
            this.employmentInfo.Location = new System.Drawing.Point(12, 169);
            this.employmentInfo.Name = "employmentInfo";
            this.employmentInfo.Size = new System.Drawing.Size(544, 74);
            this.employmentInfo.TabIndex = 2;
            this.employmentInfo.TabStop = false;
            this.employmentInfo.Text = "Employment Info";
            // 
            // incomeFrequencySelect
            // 
            this.incomeFrequencySelect.FormattingEnabled = true;
            this.incomeFrequencySelect.Items.AddRange(new object[] {
            "Yearly",
            "Monthly",
            "Bi-Weekly",
            "Weekly"});
            this.incomeFrequencySelect.Location = new System.Drawing.Point(222, 35);
            this.incomeFrequencySelect.Name = "incomeFrequencySelect";
            this.incomeFrequencySelect.Size = new System.Drawing.Size(121, 21);
            this.incomeFrequencySelect.TabIndex = 5;
            this.incomeFrequencySelect.SelectedIndex = 0;
            this.incomeFrequencySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Location = new System.Drawing.Point(469, 20);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(67, 13);
            this.employeeIDLabel.TabIndex = 9;
            this.employeeIDLabel.Text = "Employee ID";
            // 
            // isBranchEmployeeCheckbox
            // 
            this.isBranchEmployeeCheckbox.AutoSize = true;
            this.isBranchEmployeeCheckbox.Location = new System.Drawing.Point(357, 39);
            this.isBranchEmployeeCheckbox.Name = "isBranchEmployeeCheckbox";
            this.isBranchEmployeeCheckbox.Size = new System.Drawing.Size(109, 17);
            this.isBranchEmployeeCheckbox.TabIndex = 7;
            this.isBranchEmployeeCheckbox.Text = "Branch Employee";
            this.isBranchEmployeeCheckbox.UseVisualStyleBackColor = true;
            this.isBranchEmployeeCheckbox.CheckedChanged += new System.EventHandler(this.isBranchEmployeeCheckbox_CheckedChanged);
            // 
            // incomeFrequencyLabel
            // 
            this.incomeFrequencyLabel.AutoSize = true;
            this.incomeFrequencyLabel.Location = new System.Drawing.Point(222, 19);
            this.incomeFrequencyLabel.Name = "incomeFrequencyLabel";
            this.incomeFrequencyLabel.Size = new System.Drawing.Size(95, 13);
            this.incomeFrequencyLabel.TabIndex = 7;
            this.incomeFrequencyLabel.Text = "Income Frequency";
            // 
            // employeeIDInput
            // 
            this.employeeIDInput.Location = new System.Drawing.Point(472, 36);
            this.employeeIDInput.Mask = "000";
            this.employeeIDInput.Name = "employeeIDInput";
            this.employeeIDInput.ReadOnly = true;
            this.employeeIDInput.Size = new System.Drawing.Size(64, 20);
            this.employeeIDInput.TabIndex = 13;
            // 
            // incomeInput
            // 
            this.incomeInput.Location = new System.Drawing.Point(112, 35);
            this.incomeInput.Name = "incomeInput";
            this.incomeInput.Size = new System.Drawing.Size(104, 20);
            this.incomeInput.TabIndex = 3;
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Location = new System.Drawing.Point(113, 20);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(42, 13);
            this.incomeLabel.TabIndex = 2;
            this.incomeLabel.Text = "Income";
            // 
            // employerLabel
            // 
            this.employerLabel.AutoSize = true;
            this.employerLabel.Location = new System.Drawing.Point(7, 20);
            this.employerLabel.Name = "employerLabel";
            this.employerLabel.Size = new System.Drawing.Size(50, 13);
            this.employerLabel.TabIndex = 1;
            this.employerLabel.Text = "Employer";
            // 
            // employerInput
            // 
            this.employerInput.Location = new System.Drawing.Point(6, 36);
            this.employerInput.Name = "employerInput";
            this.employerInput.Size = new System.Drawing.Size(100, 20);
            this.employerInput.TabIndex = 0;
            // 
            // loanInfo
            // 
            this.loanInfo.Controls.Add(this.termInput);
            this.loanInfo.Controls.Add(this.termLabel);
            this.loanInfo.Controls.Add(this.amountLabel);
            this.loanInfo.Controls.Add(this.amountInput);
            this.loanInfo.Location = new System.Drawing.Point(172, 9);
            this.loanInfo.Name = "loanInfo";
            this.loanInfo.Size = new System.Drawing.Size(223, 74);
            this.loanInfo.TabIndex = 0;
            this.loanInfo.TabStop = false;
            this.loanInfo.Text = "Loan Info";
            // 
            // termInput
            // 
            this.termInput.Location = new System.Drawing.Point(116, 36);
            this.termInput.Name = "termInput";
            this.termInput.Size = new System.Drawing.Size(100, 20);
            this.termInput.TabIndex = 3;
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(113, 20);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(31, 13);
            this.termLabel.TabIndex = 2;
            this.termLabel.Text = "Term";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(7, 20);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "Amount";
            // 
            // amountInput
            // 
            this.amountInput.Location = new System.Drawing.Point(6, 36);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(100, 20);
            this.amountInput.TabIndex = 0;
            // 
            // completeButton
            // 
            this.completeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeButton.Location = new System.Drawing.Point(427, 15);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(110, 31);
            this.completeButton.TabIndex = 20;
            this.completeButton.Text = "Submit";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // loanStatusDisplay
            // 
            this.loanStatusDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loanStatusDisplay.Location = new System.Drawing.Point(22, 44);
            this.loanStatusDisplay.Name = "loanStatusDisplay";
            this.loanStatusDisplay.ReadOnly = true;
            this.loanStatusDisplay.Size = new System.Drawing.Size(100, 13);
            this.loanStatusDisplay.TabIndex = 50;
            // 
            // loanStatusLabel
            // 
            this.loanStatusLabel.AutoSize = true;
            this.loanStatusLabel.Location = new System.Drawing.Point(22, 25);
            this.loanStatusLabel.Name = "loanStatusLabel";
            this.loanStatusLabel.Size = new System.Drawing.Size(64, 13);
            this.loanStatusLabel.TabIndex = 14;
            this.loanStatusLabel.Text = "Loan Status";
            // 
            // manualDecisionButton
            // 
            this.manualDecisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualDecisionButton.Location = new System.Drawing.Point(427, 52);
            this.manualDecisionButton.Name = "manualDecisionButton";
            this.manualDecisionButton.Size = new System.Drawing.Size(110, 31);
            this.manualDecisionButton.TabIndex = 21;
            this.manualDecisionButton.Text = "Manual Decision";
            this.manualDecisionButton.UseVisualStyleBackColor = true;
            this.manualDecisionButton.Click += new System.EventHandler(this.manualDecisionButton_Click);
            // 
            // ApplicationInformationHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 254);
            this.Controls.Add(this.manualDecisionButton);
            this.Controls.Add(this.loanStatusLabel);
            this.Controls.Add(this.loanStatusDisplay);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.loanInfo);
            this.Controls.Add(this.employmentInfo);
            this.Controls.Add(this.applicantInfo);
            this.Name = "ApplicationInformationHandler";
            this.Text = "Application Input";
            this.applicantInfo.ResumeLayout(false);
            this.applicantInfo.PerformLayout();
            this.employmentInfo.ResumeLayout(false);
            this.employmentInfo.PerformLayout();
            this.loanInfo.ResumeLayout(false);
            this.loanInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox applicantInfo;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.TextBox emailAddressInput;
        private System.Windows.Forms.MaskedTextBox ssnInput;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.MaskedTextBox phoneNumberInput;
        private System.Windows.Forms.GroupBox employmentInfo;
        private System.Windows.Forms.ComboBox incomeFrequencySelect;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.CheckBox isBranchEmployeeCheckbox;
        private System.Windows.Forms.Label incomeFrequencyLabel;
        private System.Windows.Forms.MaskedTextBox employeeIDInput;
        private System.Windows.Forms.TextBox incomeInput;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label employerLabel;
        private System.Windows.Forms.TextBox employerInput;
        private System.Windows.Forms.GroupBox loanInfo;
        private System.Windows.Forms.TextBox termInput;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.TextBox loanStatusDisplay;
        private System.Windows.Forms.Label loanStatusLabel;
        private System.Windows.Forms.Button manualDecisionButton;
    }
}