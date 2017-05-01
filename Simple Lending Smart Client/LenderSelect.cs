using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Simple_Lending_Smart_Client
{
    public partial class LenderSelect : Form
    {
        public string lendercode;

        public LenderSelect(List<string> lenders)
        {
            InitializeComponent();
            CenterToScreen();
            lenderList.DataSource = lenders;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            lendercode = Regex.Replace(lenderList.SelectedValue.ToString().Split('-')[0], @"\s", "");
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
