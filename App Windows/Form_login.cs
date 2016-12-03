using System;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace App_Windows
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            button_login.Enabled = false;

            RestClient cliente = new RestClient("http://localhost/API_Projeto/api/user/login");
            RestRequest request = new RestRequest(Method.GET);

            request.AddHeader("username", textBox_username.Text);
            request.AddHeader("password", textBox_password.Text);
            request.AddHeader("dispositivo", "Windows");

            IRestResponse resposta = cliente.Execute(request);

            if (resposta.ErrorException != null)
            {
                MessageBox.Show(resposta.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button_login.Enabled = true;
            }
            else
            {
                if (resposta.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(resposta.StatusDescription, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button_login.Enabled = true;
                }
                else
                {
                    string recebido = resposta.Content;
                    string token = JObject.Parse(recebido).Property("token").Value.ToString();
                    
                    
                    ((Form_home)Application.OpenForms[0]).token = token;
                    ((Form_home)Application.OpenForms[0]).update_ui(true,"logout",textBox_username.Text);
                    this.Close();
                }
            }
        }
    }
}
