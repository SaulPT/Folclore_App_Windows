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

            RestClient cliente = new RestClient("http://localhost/Folclore_API/api/user/login");
            RestRequest request = new RestRequest(Method.GET);

            request.AddHeader("username", textBox_username.Text);
            request.AddHeader("password", textBox_password.Text);
            request.AddHeader("dispositivo", "Windows");

            //LOG
            Log.escrever("Login", cliente.BaseUrl.ToString(), request.Method.ToString(), request.Parameters, null);
            //

            IRestResponse resposta = cliente.Execute(request);
            
            if (resposta.ErrorException != null)
            {
                MessageBox.Show(resposta.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button_login.Enabled = true;

                //LOG
                Log.escrever("ERRO", resposta.ErrorMessage, resposta.ErrorException.HResult.ToString(), null, null);
                //
            }
            else
            {
                //LOG
                Log.escrever("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);
                //

                if (resposta.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(resposta.StatusDescription, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button_login.Enabled = true;
                }
                else
                {
                    string token = JObject.Parse(resposta.Content).Property("token").Value.ToString();
                    string username = JObject.Parse(resposta.Content).Property("username").Value.ToString();

                    Form_home form_inicial = (Form_home)Application.OpenForms[0];
                    form_inicial.token = token;
                    form_inicial.username = username;
                    form_inicial.menu_terminar_sessao.Visible = true;

                    this.Visible = false;
                    this.Close();

                    form_inicial.abrir_area_pessoal();
                }
            }
        }

        private void textBox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
