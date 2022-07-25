using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_client
{
    public partial class Form1 : Form
    {
        string URL = "http://localhost:3000/pokemon/";
        string ROUTE = "";
        public Form1()
        {
            InitializeComponent();
        }

        private bool loginUser()
        {
            loginForm login = new loginForm();
            this.Hide();
            login.ShowDialog();
            if (login.loginOK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool registerUser()
        {
            signupForm signup = new signupForm();
            this.Hide();
            signup.ShowDialog();
            if (signup.registerOK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void getAll_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.GET);
            IRestResponse<List<Pokemon>> response = client.Execute<List<Pokemon>>(request);
            listBox1.Items.Clear();
            listBox1.Items.Add("All Pokemon:");
            foreach (Pokemon pokemon in response.Data)
            {
                listBox1.Items.Add("ID: " + pokemon.id + " Name: " + pokemon.name + " Type: "
                + pokemon.type + " Health: " + pokemon.health + " Region: " + pokemon.region);
            }
        }

        private void getPokemonById_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String ROUTE = id_numeric.Value.ToString();
            var request = new RestRequest(ROUTE, Method.GET);
            IRestResponse<List<Pokemon>> response = client.Execute<List<Pokemon>>(request);
            if (response.StatusCode == (HttpStatusCode)404)
            {
                MessageBox.Show("Pokemon not found!");
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Pokemon with ID: " + id_numeric.Value);
                foreach (Pokemon pokemon in response.Data)
                {
                    listBox1.Items.Add("ID: " + pokemon.id + " Name: " + pokemon.name + " Type: "
                    + pokemon.type + " Health: " + pokemon.health + " Region: " + pokemon.region);
                }
            }
        }

        private void insertPokemon_btn_Click(object sender, EventArgs e)
        {
            if (loginUser())
            {
                this.Show();
                var client = new RestClient(URL);
                var request = new RestRequest(ROUTE, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(new Pokemon
                {
                    name = name_tb.Text,
                    type = type_tb.Text,
                    health = (int)health_numeric.Value,
                    region = region_tb.Text
                });
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == (HttpStatusCode)400)
                {
                    MessageBox.Show("Insert failed!");
                }
                else
                {
                    MessageBox.Show("Pokemon inserted.");
                }
            }
            else
            {
                MessageBox.Show("You need to log in first!");
                this.Show();
            }
        }

        private void updatePokemon_btn_Click(object sender, EventArgs e)
        {
            if (loginUser())
            {
                this.Show();
                var client = new RestClient(URL);
                var request = new RestRequest(ROUTE, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(new Pokemon
                {
                    id = (int)id_numeric.Value,
                    name = name_tb.Text,
                    type = type_tb.Text,
                    health = (int)health_numeric.Value,
                    region = region_tb.Text
                });
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == (HttpStatusCode)400)
                {
                    MessageBox.Show("Update failed!");
                }
                else
                {
                    MessageBox.Show("Pokemon updated.");
                }
            }
            else
            {
                MessageBox.Show("You need to log in first!");
                this.Show();
            }
        }

        private void deletePokemon_btn_Click(object sender, EventArgs e)
        {
            if (loginUser())
            {
                this.Show();
                var client = new RestClient(URL);
                String ROUTE = id_numeric.Value.ToString();
                var request = new RestRequest(ROUTE, Method.DELETE);
                request.AddParameter("id", id_numeric.Value);
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == (HttpStatusCode)400)
                {
                    MessageBox.Show("Delete failed!");
                }
                else
                {
                    MessageBox.Show("Pokemon deleted.");
                }
            }
            else
            {
                MessageBox.Show("You need to log in first!");
                this.Show();
            }
        }
            

        private void id_numeric_ValueChanged(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String ROUTE = id_numeric.Value.ToString();
            var request = new RestRequest(ROUTE, Method.GET);
            IRestResponse<List<Pokemon>> response = client.Execute<List<Pokemon>>(request);
            foreach (Pokemon pokemon in response.Data)
            {
                name_tb.Text = pokemon.name;
                type_tb.Text = pokemon.type;
                health_numeric.Value = pokemon.health;
                region_tb.Text = pokemon.region;
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (registerUser())
            {
                MessageBox.Show("Registration successful!");
                this.Show();
            }
            else
            {
                MessageBox.Show("Registration failed!");
                this.Show();
            }
        }
    }
}
