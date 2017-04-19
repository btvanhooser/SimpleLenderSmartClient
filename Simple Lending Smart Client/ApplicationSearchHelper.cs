using System;
using System.Windows.Forms;

namespace Simple_Lending_Smart_Client
{
    public partial class ApplicationSearchHelper : Form
    {
        public string lastName;
        public string firstName;

        public ApplicationSearchHelper()
        {
            InitializeComponent();
        }

        private void lastNameInput_TextChanged(object sender, EventArgs e)
        {
            if (lastNameInput.Text.Length == 0)
            {
                firstNameInput.ReadOnly = true;
                firstNameInput.Text = "";
            }
            else
            {
                firstNameInput.ReadOnly = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (lastNameInput.Text.Length == 0)
            {
                MessageBox.Show("Last name cannot be blank.");
                return;
            }

            this.lastName = lastNameInput.Text;
            this.firstName = firstNameInput.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
