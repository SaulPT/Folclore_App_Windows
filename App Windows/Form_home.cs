using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace App_Windows
{
    public partial class Form_home : Form
    {
        public string token,username;
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

        private void button_login_Click(object sender, EventArgs e)
        {
            if (button_login.Text == "login")
            {
                new Form_login().ShowDialog();
            }
            else
            {
                update_ui(false);
            }
        }

        public void update_ui(bool estado_login)
        {
            if (estado_login)
            {
                menu_area_pessoal.Enabled = true;
                button_login.Text = "logout";
                label_username.Text = "Utilizador: " + username;
            }
            else
            {
                menu_area_pessoal.Enabled = false;
                button_login.Text = "login";
                label_username.Text = "Utilizador: ";
            }
        }

        private void Form_home_Shown(object sender, EventArgs e)
        {
            RestClient cliente = new RestClient("http://localhost/Folclore_API/api/noticias");
            RestRequest request = new RestRequest(Method.GET);

            IRestResponse resposta = cliente.Execute(request);

            //LOG
            Log.escrever("Pedido",cliente.BaseUrl.ToString(),request.Method.ToString(),request.Parameters,null);
            //

            if (resposta.ErrorException == null)
            {
                string json = resposta.Content;
                noticias = JsonConvert.DeserializeObject<List<Noticia>>(json);
                listBox_noticias.DataSource = noticias;

                //LOG
                Log.escrever("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);
                //
            }
            else
            {
                MessageBox.Show(resposta.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //LOG
                Log.escrever("ERRO", resposta.ErrorMessage, resposta.ErrorException.HResult.ToString(), null, null);
                //
            }
        }

        private void menu_refresh_Click(object sender, EventArgs e)
        {
            this.OnShown(e);
        }

        private void menu_area_pessoal_Click(object sender, EventArgs e)
        {
            new Form_area_pessoal(username,token).ShowDialog()
        }
    }
}
