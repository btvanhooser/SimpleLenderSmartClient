using System;
using System.Windows.Forms;

namespace Simple_Lending_Smart_Client
{
    public partial class ManualDecisionHelper : Form
    {
        public string newDecision;

        public ManualDecisionHelper()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            newDecision = manualDecisionSelect.SelectedItem.ToString();
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
