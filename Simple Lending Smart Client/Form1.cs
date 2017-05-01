using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Simple_Lending_Smart_Client
{
    public partial class Form1 : Form
    {
        public string uri = Utilities.uri;
        public string lendercode;
        public Dictionary<string,LenderModel> lenderObjectDict;
        public LenderModel lenderInUse;

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var username = usernameInput.Text;
            var password = getHashSha256(passwordInput.Text);
            var userToken = checkIfValidUser(username, password);
            if (userToken == null)
            {
                MessageBox.Show("Incorrect Authentication");
            }
            else if (userToken.Equals("-1"))
            {
                return;
            }
            else
            {
                MainWindow mainWindow = new MainWindow(userToken, lenderInUse);
                mainWindow.Show(this);
                Hide();
            }
        }

        private string checkIfValidUser(string username, string password)
        {
            var client = new RestClient(uri + "/auth");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\n\t\"username\": \"" + username + "\",\n\t\"password\": \"" + password + "\"\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            Response r = JsonConvert.DeserializeObject<Response>(response.Content);
            var accessToken = r.access_token;

            if (accessToken == null)
            {
                return accessToken;
            }

            client = new RestClient(uri + "/lender");
            request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "JWT " + accessToken);
            response = client.Execute(request);

            LenderModel L = JsonConvert.DeserializeObject<LenderModel>(response.Content);
            lendercode = L.lendercode;

            lenderObjectDict = new Dictionary<string, LenderModel>();
            var lenderOptions = new List<string>();
            client = new RestClient(uri + "/lenders");
            request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "JWT " + accessToken);

            response = client.Execute(request);
            r = JsonConvert.DeserializeObject<Response>(response.Content);

            foreach (var lender in r.Lenders)
            {
                if (!lender.lendercode.Equals("000"))
                {
                    lenderOptions.Add(lender.lendercode + " - " + lender.name);
                    lenderObjectDict[lender.lendercode] = lender;
                }
            }

            if (lendercode.Equals("000"))
            {

                using (var form = new LenderSelect(lenderOptions))
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        lendercode = form.lendercode;
                    }
                    else
                    {
                        return "-1";
                    }
                }
            }
            lenderInUse = lenderObjectDict[lendercode];
            return accessToken;
        }

        public static string getHashSha256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}
