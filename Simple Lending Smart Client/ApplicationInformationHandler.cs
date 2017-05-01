using Newtonsoft.Json;
using RestSharp;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Simple_Lending_Smart_Client
{
    public partial class ApplicationInformationHandler : Form
    {
        private ApplicationModel currentApp;
        private string userToken;
        private string lenderCode;
        private string uri = Utilities.uri;

        public ApplicationInformationHandler(string userToken, string lenderCode, ApplicationModel app = null)
        {
            InitializeComponent();
            CenterToScreen();
            this.userToken = userToken;
            this.lenderCode = lenderCode;

            if (app != null)
            {
                loadInApplication(app);
            }
            else
            {
                this.loanStatusDisplay.Text = "Unsubmitted";
                this.manualDecisionButton.Hide();
                this.completeButton.Height = 68;
                this.completeButton.Text = "Submit";
                currentApp = new ApplicationModel();
            }
        }

        private void loadInApplication(ApplicationModel app)
        {
            this.Text = "Application Input - Application #" + app.id;
            this.amountInput.Text = "$" + app.requestedAmount;
            this.termInput.Text = app.requestedTerm + "";
            this.firstNameInput.Text = app.firstname;
            this.lastNameInput.Text = app.lastname;
            this.ssnInput.Text = app.ssn + "";
            this.phoneNumberInput.Text = app.phoneNumber;
            this.emailAddressInput.Text = app.emailAddress;
            this.employerInput.Text = app.employer;
            this.incomeInput.Text = "$" + app.income;
            this.incomeFrequencySelect.SelectedItem = app.incomeFrequency;
            this.loanStatusDisplay.Text = app.status;
            if (app.isBranchEmployee.Equals("yes"))
            {
                this.isBranchEmployeeCheckbox.Checked = true;
                this.employeeIDInput.ReadOnly = false;
                this.employeeIDInput.Text = app.employeeID + "";
            }
            this.completeButton.Text = "Re-Submit";
            this.completeButton.Height = 31;
            this.manualDecisionButton.Show();
            currentApp = app;
        }

        private void IncomeInput_Leave(object sender, EventArgs e)
        {
            var result = dollarAmountValid(incomeInput.Text);
            if (result.Item1)
            {
                incomeInput.Text = result.Item2;
            }
            else
            {
                MessageBox.Show("Income should be a whole number.");
                incomeInput.Text = result.Item2;
            }
        }

        private void AmountInput_Leave(object sender, EventArgs e)
        {
            var result = dollarAmountValid(amountInput.Text);
            if (result.Item1)
            {
                amountInput.Text = result.Item2;
            }
            else
            {
                MessageBox.Show("Amount should be a whole number.");
                amountInput.Text = result.Item2;
            }
        }

        private Tuple<bool,string> dollarAmountValid(string input)
        {
            try {
                int test;
                if (incomeInput.Text.ToCharArray()[0] == '$')
                {
                    test = int.Parse(input.TrimStart('$'));
                }
                else
                {
                    test = int.Parse(input);
                }
                return new Tuple<bool, string>(true, "$" + test);
            }
            catch (Exception e)
            {
                return new Tuple<bool, string>(false, "");
            }
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            string validationIssues = ValidateForm();

            if (validationIssues.Length > 0) {
                MessageBox.Show("The application could not be submitted for the following reasons:\n" + validationIssues);
                return;
            }

            currentApp.firstname = this.firstNameInput.Text;
            currentApp.lastname = this.lastNameInput.Text;
            currentApp.ssn = int.Parse(Regex.Replace(ssnInput.Text, @"-", ""));
            currentApp.phoneNumber = this.phoneNumberInput.Text;
            currentApp.emailAddress = this.emailAddressInput.Text;
            currentApp.employer = this.employerInput.Text;
            currentApp.income = int.Parse(this.incomeInput.Text.TrimStart('$'));
            currentApp.incomeFrequency = this.incomeFrequencySelect.SelectedItem.ToString();
            currentApp.isBranchEmployee = (this.isBranchEmployeeCheckbox.Checked) ? "yes" : "no";
            currentApp.employeeID = (isBranchEmployeeCheckbox.Checked) ? int.Parse(this.employeeIDInput.Text) : 0;
            currentApp.requestedAmount = int.Parse(this.amountInput.Text.TrimStart('$'));
            currentApp.requestedTerm = int.Parse(this.termInput.Text);

            if(currentApp.id == 0)
            {
                SubmitApp();
            }
            else
            {
                UpdateApp();
            }
        }

        private void UpdateApp()
        {
            var client = new RestClient(uri + "/application");
            var request = new RestRequest(Method.PUT);
            request.AddHeader("authorization", "JWT " + userToken);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\n\t\"id\":        \"" + currentApp.id + 
                                                   "\",\n\t\"firstname\": \"" + currentApp.firstname +
                                                   "\",\n\t\"lastname\":  \"" + currentApp.lastname +
                                                   "\",\n\t\"ssn\":       " + currentApp.ssn +
                                                   ",\n\t\"employer\":  \"" + currentApp.employer +
                                                   "\",\n\t\"income\":    " + currentApp.income +
                                                   ",\n\t\"incomeFrequency\": \"" + currentApp.incomeFrequency +
                                                   "\",\n\t\"requestedAmount\": " + currentApp.requestedAmount +
                                                   ",\n\t\"requestedTerm\":   " + currentApp.requestedTerm +
                                                   ",\n\t\"phoneNumber\":     \"" + currentApp.phoneNumber +
                                                   "\",\n\t\"emailAddress\":    \"" + currentApp.emailAddress +
                                                   "\",\n\t\"isBranchEmployee\":\"" + currentApp.isBranchEmployee +
                                                   "\",\n\t\"employeeID\":      " + currentApp.employeeID +
                                                   ",\n\t\"lendercode\":      \"" + lenderCode + "\"\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Response r = JsonConvert.DeserializeObject<Response>(response.Content);

            if (r.Application == null)
            {
                MessageBox.Show("There was an issue re-submitting the application for the following reason: " + r.Message + "\n\nPlease try again.");
                return;
            }
            currentApp = r.Application;
            loadInApplication(currentApp);
            MessageBox.Show("Application re-submitted successfully and the status has been updated.");
        }

        private void SubmitApp()
        {
            var client = new RestClient(uri + "/application");
            var request = new RestRequest(Method.POST);
            request.AddHeader("authorization", "JWT " + userToken);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\n\t\"firstname\": \"" + currentApp.firstname + 
                                                   "\",\n\t\"lastname\":  \"" + currentApp.lastname + 
                                                   "\",\n\t\"ssn\":       " + currentApp.ssn + 
                                                   ",\n\t\"employer\":  \"" + currentApp.employer + 
                                                   "\",\n\t\"income\":    " + currentApp.income + 
                                                   ",\n\t\"incomeFrequency\": \"" + currentApp.incomeFrequency + 
                                                   "\",\n\t\"requestedAmount\": " + currentApp.requestedAmount + 
                                                   ",\n\t\"requestedTerm\":   " + currentApp.requestedTerm + 
                                                   ",\n\t\"phoneNumber\":     \"" + currentApp.phoneNumber + 
                                                   "\",\n\t\"emailAddress\":    \"" + currentApp.emailAddress + 
                                                   "\",\n\t\"isBranchEmployee\":\"" + currentApp.isBranchEmployee + 
                                                   "\",\n\t\"employeeID\":      " + currentApp.employeeID + 
                                                   ",\n\t\"lendercode\":      \"" + lenderCode + "\"\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Response r = JsonConvert.DeserializeObject<Response>(response.Content);

            if (r.Application == null)
            {
                MessageBox.Show("There was an issue submitting the application for the following reason: " + r.Message + "\n\nPlease try again.");
                return;
            }
            currentApp = r.Application;
            loadInApplication(currentApp);
            MessageBox.Show("Application submitted successfully and the status has been updated.");
        }

        private string ValidateForm()
        {
            var errorList = "";
            if (this.firstNameInput.Text.Length == 0)
            {
                errorList += "\nFirst name cannot be blank.";
            }
            if (this.lastNameInput.Text.Length == 0)
            {
                errorList += "\nLast name cannot be blank.";
            }
            if (this.ssnInput.Text.Length < 9)
            {
                errorList += "\nSSN must be exactly 9 digits.";
            }
            if (this.phoneNumberInput.Text.Length < 10)
            {
                errorList += "\nPhone number cannot be blank or incomplete.";
            }
            if (this.incomeInput.Text.Length == 0)
            {
                errorList += "\nIncome cannot be left blank.";
            }
            if (this.amountInput.Text.Length == 0)
            {
                errorList += "\nAmount cannot be left blank.";
            }
            if (this.termInput.Text.Length == 0)
            {
                errorList += "\nTerm cannot be left blank.";
            }
            if (this.isBranchEmployeeCheckbox.Checked && this.employeeIDInput.Text.Length == 0)
            {
                errorList += "\nEmployee ID must be entered if Branch Employee checkbox is checked.";
            }
            return errorList;
        }

        private void manualDecisionButton_Click(object sender, EventArgs e)
        {
            string validationIssues = ValidateForm();

            if (validationIssues.Length > 0)
            {
                MessageBox.Show("The application could not be submitted for the following reasons:\n" + validationIssues);
                return;
            }

            using (var form = new ManualDecisionHelper())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    currentApp.status = form.newDecision;
                }
                else
                {
                    return;
                }
            }

            currentApp.firstname = this.firstNameInput.Text;
            currentApp.lastname = this.lastNameInput.Text;
            currentApp.ssn = int.Parse(Regex.Replace(ssnInput.Text, @"-", ""));
            currentApp.phoneNumber = this.phoneNumberInput.Text;
            currentApp.emailAddress = this.emailAddressInput.Text;
            currentApp.employer = this.employerInput.Text;
            currentApp.income = int.Parse(this.incomeInput.Text.TrimStart('$'));
            currentApp.incomeFrequency = this.incomeFrequencySelect.SelectedItem.ToString();
            currentApp.isBranchEmployee = (this.isBranchEmployeeCheckbox.Checked) ? "yes" : "no";
            currentApp.employeeID = (isBranchEmployeeCheckbox.Checked) ? int.Parse(this.employeeIDInput.Text) : 0;
            currentApp.requestedAmount = int.Parse(this.amountInput.Text.TrimStart('$'));
            currentApp.requestedTerm = int.Parse(this.termInput.Text);

            var client = new RestClient(uri + "/application");
            var request = new RestRequest(Method.PUT);
            request.AddHeader("authorization", "JWT " + userToken);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\n\t\"id\":        \"" + currentApp.id +
                                                   "\",\n\t\"firstname\": \"" + currentApp.firstname +
                                                   "\",\n\t\"lastname\":  \"" + currentApp.lastname +
                                                   "\",\n\t\"ssn\":       " + currentApp.ssn +
                                                   ",\n\t\"employer\":  \"" + currentApp.employer +
                                                   "\",\n\t\"income\":    " + currentApp.income +
                                                   ",\n\t\"incomeFrequency\": \"" + currentApp.incomeFrequency +
                                                   "\",\n\t\"requestedAmount\": " + currentApp.requestedAmount +
                                                   ",\n\t\"requestedTerm\":   " + currentApp.requestedTerm +
                                                   ",\n\t\"phoneNumber\":     \"" + currentApp.phoneNumber +
                                                   "\",\n\t\"emailAddress\":    \"" + currentApp.emailAddress +
                                                   "\",\n\t\"isBranchEmployee\":\"" + currentApp.isBranchEmployee +
                                                   "\",\n\t\"employeeID\":      " + currentApp.employeeID +
                                                   ",\n\t\"lendercode\":      \"" + lenderCode + 
                                                   "\",\n\t\"status\":          \"" + currentApp.status + "\"\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Response r = JsonConvert.DeserializeObject<Response>(response.Content);

            if (r.Application == null)
            {
                MessageBox.Show("There was an issue saving the application for the following reason: " + r.Message + "\n\nPlease try again.");
                return;
            }
            currentApp = r.Application;
            loadInApplication(currentApp);
            MessageBox.Show("Application was successfully manually decisioned and the status has been updated.");
        }

        private void isBranchEmployeeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (isBranchEmployeeCheckbox.Checked)
            {
                employeeIDInput.ReadOnly = false;
            }
            else
            {
                employeeIDInput.ReadOnly = true;
                employeeIDInput.Text = "";
            }
        }
    }
}
