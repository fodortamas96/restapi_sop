using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_client
{
    public partial class signupForm : Form
    {
        string URL = "http://localhost:3000/auth";
        string ROUTE = "";
        public bool registerOK { get; set; }
        public signupForm()
        {
            InitializeComponent();
            registerOK = false;
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            String ROUTE = "/register";
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new User
            {
                username = username_tb.Text,
                email = email_tb.Text,
                password = password_tb.Text
            });
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == (HttpStatusCode)201)
            {
                registerOK = true;
            }
            else if (response.StatusCode == (HttpStatusCode)409)
            {
                MessageBox.Show("This email is already in use!");
                registerOK = true;
            }
            this.Close();
        }
    }
}
