namespace Simple_Lending_Smart_Client
{
    partial class LenderSelect
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
            this.lenderList = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.formLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lenderList
            // 
            this.lenderList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lenderList.FormattingEnabled = true;
            this.lenderList.Location = new System.Drawing.Point(12, 25);
            this.lenderList.Name = "lenderList";
            this.lenderList.Size = new System.Drawing.Size(184, 21);
            this.lenderList.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 52);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(91, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(109, 52);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Location = new System.Drawing.Point(12, 9);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(114, 13);
            this.formLabel.TabIndex = 3;
            this.formLabel.Text = "Please select a lender:";
            // 
            // LenderSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 87);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.lenderList);
            this.Name = "LenderSelect";
            this.Text = "LenderSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lenderList;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label formLabel;
    }
}