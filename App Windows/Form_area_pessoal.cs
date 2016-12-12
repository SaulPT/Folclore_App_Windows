using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Windows
{
    public partial class Form_area_pessoal : Form
    {
        string username,token;
        List<Grupo> grupos;
        
        public Form_area_pessoal(string username,string token)
        {
            InitializeComponent();
            this.username = username;
            this.token = token;
        }

        private void Form_area_pessoal_Load(object sender, EventArgs e)
        {
            label_username.Text = username;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            ((Form_home)Application.OpenForms[0]).menu_terminar_sessao_Click(sender, e);
            this.Close();
        }

        private void Form_area_pessoal_Shown(object sender, EventArgs e)
        {
            RestClient cliente = new RestClient("http://localhost/Folclore_API/api/user/grupos");
            RestRequest request = new RestRequest(Method.GET);

            request.AddHeader("token", token);

            //LOG
            Log.escrever("Login", cliente.BaseUrl.ToString(), request.Method.ToString(), request.Parameters, null);
            //

            IRestResponse resposta = cliente.Execute(request);

            if (resposta.ErrorException != null)
            {
                MessageBox.Show(resposta.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //LOG
                Log.escrever("ERRO", resposta.ErrorMessage, resposta.ErrorException.HResult.ToString(), null, null);
                //
            }
            else
            {
                string json = resposta.Content;
                grupos = JsonConvert.DeserializeObject<List<Grupo>>(json);
                listBox_grupos.DataSource = grupos;

                //LOG
                Log.escrever("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);
                //
            }
        }

        private void button_informacao_Click(object sender, EventArgs e)
        {
            new Form_grupo_informacao(token).ShowDialog();
        }
    }
}
