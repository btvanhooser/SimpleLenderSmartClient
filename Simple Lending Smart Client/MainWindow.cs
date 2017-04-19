using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Simple_Lending_Smart_Client
{
    public partial class MainWindow : Form
    {
        public string userToken;
        public LenderModel lenderInUse;
        public Dictionary<int, ApplicationModel> currentApplications;
        public string uri = Utilities.uri;

        public MainWindow(string userToken, LenderModel lenderInUse)
        {
            InitializeComponent();
            this.userToken = userToken;
            this.lenderInUse = lenderInUse;
            this.Text = lenderInUse.name;
            RefreshWindow();
        }

        private void newAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationInformationHandler nextWindow = new ApplicationInformationHandler(userToken, lenderInUse.lendercode);
            nextWindow.ShowDialog();
            RefreshWindow();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (applicationDisplay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Must select at least one application.");
                return;
            }
            if (applicationDisplay.SelectedRows.Count > 1)
            {
                MessageBox.Show("Can only edit one application at a time.");
                return;
            }

            foreach (DataGridViewRow row in applicationDisplay.SelectedRows)
            {
                var id = int.Parse(row.Cells[0].Value.ToString());
                var application = GetSpecificApplication(id);
                ApplicationInformationHandler nextWindow = new ApplicationInformationHandler(userToken, lenderInUse.lendercode, application);
                nextWindow.ShowDialog();
                RefreshWindow();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (applicationDisplay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Must select at least one application.");
                return;
            }

            if (MessageBox.Show(this, "Are you sure you want to delete all selected applications?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in applicationDisplay.SelectedRows)
                {
                    var id = int.Parse(row.Cells[0].Value.ToString());
                    if (!DeleteApplication(id))
                    {
                        MessageBox.Show("Deletion process stopped. Error with deleteing selected applications.");
                        break;
                    }
                }
                RefreshWindow();
            }

        }



        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshWindow();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ApplicationSearchHelper())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (form.firstName.Length == 0)
                    {
                        SearchByLastName(form.lastName);
                    }
                    else
                    {
                        SearchByFullName(form.lastName, form.firstName);
                    }
                }
            }
        }

        private void RefreshWindow()
        {
            var client = new RestClient(uri + "/applications/" + lenderInUse.lendercode);
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "JWT " + userToken);
            IRestResponse response = client.Execute(request);

            Response r = JsonConvert.DeserializeObject<Response>(response.Content);

            if (r.Applications == null)
            {
                MessageBox.Show("Not able to successfully communicate with the server. Error Message: " + r.Message);
                return;
            }

            LoadAppListToTable(r.Applications);
        }

        private ApplicationModel GetSpecificApplication(int id)
        {
            var client = new RestClient(uri + "/application/" + id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "JWT " + userToken);
            IRestResponse response = client.Execute(request);

            Response r = JsonConvert.DeserializeObject<Response>(response.Content);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Error retrieving full application info. Error message: " + r.Message);
                return null;
            }

            return r.Application;
        }

        private bool DeleteApplication(int id)
        {
            var client = new RestClient(uri + "/application/" + id);
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("authorization", "JWT " + userToken);
            IRestResponse response = client.Execute(request);

            Response r = JsonConvert.DeserializeObject<Response>(response.Content);

            return (response.StatusCode == System.Net.HttpStatusCode.OK) ? true : false;
        }

        private void LoadAppListToTable(List<ApplicationModel> appList)
        {
            currentApplications = new Dictionary<int, ApplicationModel>();

            var table = new DataTable();
            table.Columns.Add("Application ID");
            table.Columns.Add("First Name");
            table.Columns.Add("Last Name");
            table.Columns.Add("Status");

            foreach (var app in appList)
            {
                currentApplications[app.id] = app;
                var row = table.NewRow();
                row["Application ID"] = app.id;
                row["First Name"] = app.firstname;
                row["Last Name"] = app.lastname;
                row["Status"] = app.status;
                table.Rows.Add(row);
            }

            applicationDisplay.DataSource = table;
        }

        private void SearchByLastName(string lastName)
        {
            var client = new RestClient(uri + "/applications/" + lenderInUse.lendercode + "/" + lastName);
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "JWT " + userToken);
            IRestResponse response = client.Execute(request);

            Response r = JsonConvert.DeserializeObject<Response>(response.Content);

            if (r.Applications == null)
            {
                MessageBox.Show("Error while performing search operation. Error message: " + r.Message);
                return;
            }
            else if (r.Applications.Count == 0)
            {
                MessageBox.Show("No applications found with that last name.");
            }

            LoadAppListToTable(r.Applications);
        }

        private void SearchByFullName(string lastName, string firstName)
        {
            var client = new RestClient(uri + "/applications/" + lenderInUse.lendercode + "/" + lastName + "/" + firstName);
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "JWT " + userToken);
            IRestResponse response = client.Execute(request);

            Response r = JsonConvert.DeserializeObject<Response>(response.Content);

            if (r.Applications == null)
            {
                MessageBox.Show("Error while performing search operation. Error message: " + r.Message);
                return;
            }
            else if (r.Applications.Count == 0)
            {
                MessageBox.Show("No applications found with that full name.");
            }

            LoadAppListToTable(r.Applications);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
            base.OnFormClosing(e);
        }
    }
}
