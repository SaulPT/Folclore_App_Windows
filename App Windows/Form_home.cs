using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;


namespace App_Windows
{
    public partial class Form_home : Form
    {
        public string token;
        private List<Noticia> noticias;

        public Form_home()
        {
            InitializeComponent();
        }

        private void listBox_noticias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_noticias.SelectedIndex >= 0)
            {
                Noticia noticia_selecionada = noticias.Find(n => n == listBox_noticias.SelectedItem);
                label_titulo.Text = noticia_selecionada.titulo;
                label_data.Text = noticia_selecionada.data_criacao.ToString();
                label_conteudo.Text = noticia_selecionada.conteudo;
            }
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
            if (button_login.Text == "login")
            {
                new Form_login().ShowDialog();
            }
            else
            {
                label_username.Text = "Utilizador: ";
                button_noticias.Enabled = false;
                button_login.Text = "login";

                listBox_noticias.DataSource = null;
                label_titulo.Text = "Título";
                label_data.Text = "data";
                label_conteudo.Text = "Conteúdo";
            }
            
        }

        public void update_ui(bool estado_botao_noticias,string texto_botao_login, string texto_username)
        {
            button_noticias.Enabled = estado_botao_noticias;
            button_login.Text = texto_botao_login;
            label_username.Text = "Utilizador: " + texto_username;
        }
    }
}
