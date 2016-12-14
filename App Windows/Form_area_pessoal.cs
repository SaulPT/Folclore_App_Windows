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
        private string username,token;
        private List<Grupo> grupos;
        
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

        public void Form_area_pessoal_Shown(object sender, EventArgs e)
        {
            RestClient cliente = new RestClient(Form_home.API_URL+"/user/grupos");
            RestRequest pedido = new RestRequest(Method.GET);

            pedido.AddHeader("token", token);
            
            Log.escrever("Pedido", cliente.BaseUrl.ToString(), pedido.Method.ToString(), pedido.Parameters, null);
            
            IRestResponse resposta = cliente.Execute(pedido);

            if (resposta.ErrorException != null)
            {
                MessageBox.Show(resposta.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.escrever("ERRO", resposta.ErrorMessage, resposta.ErrorException.HResult.ToString(), null, null);
            }
            else
            {
                string json = resposta.Content;
                grupos = JsonConvert.DeserializeObject<List<Grupo>>(json);
                Log.escrever("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);
            }

            listBox_grupos.DataSource = grupos;
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Form_area_pessoal_Shown(sender, e);
        }

        private void button_informacao_Click(object sender, EventArgs e)
        {
            new Form_grupo_informacao(token,(Grupo)listBox_grupos.SelectedItem).ShowDialog();
        }
    }
}
