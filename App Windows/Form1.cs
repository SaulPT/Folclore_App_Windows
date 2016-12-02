using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace App_Windows
{
    public partial class Form1 : Form
    {
        List<Noticia> noticias;
        string token;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox_noticias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Noticia noticia_selecionada = noticias.Find(n => n == listBox_noticias.SelectedItem);
            label_titulo.Text = noticia_selecionada.titulo;
            label_data.Text = noticia_selecionada.data_criacao.ToString();
            label_conteudo.Text = noticia_selecionada.conteudo;
        }

        private void button_noticias_Click(object sender, EventArgs e)
        {
            RestClient cliente = new RestClient("http://localhost/API_Projeto/api/noticias");
            RestRequest request = new RestRequest(Method.GET);

            request.AddHeader("token", token);

            string json = cliente.Execute(request).Content;
            noticias = JsonConvert.DeserializeObject<List<Noticia>>(json);

            listBox_noticias.DataSource = noticias;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            RestClient cliente = new RestClient("http://localhost/API_Projeto/api/user/login");
            RestRequest request = new RestRequest(Method.GET);

            request.AddHeader("username", textBox_username.Text);
            request.AddHeader("password", textBox_password.Text);
            request.AddHeader("dispositivo", "Windwows");

            string json = cliente.Execute(request).Content;
            token = JObject.Parse(json).Property("token").Value.ToString();

            button_noticias.Enabled = true;
        }
    }
}
