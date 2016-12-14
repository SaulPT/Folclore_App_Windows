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
        public static string API_URL = "http://localhost/FolcloreOnline/api";

        public string token, username;
        private List<Noticia> noticias;
        RestClient cliente;
        RestRequest pedido;
        IRestResponse resposta;

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
        

        private void Form_home_Shown(object sender, EventArgs e)
        {
            cliente = new RestClient(API_URL+"/noticias");
            pedido = new RestRequest(Method.GET);
            
            Log.escrever("Pedido", cliente.BaseUrl.ToString(), pedido.Method.ToString(), pedido.Parameters, null);

            resposta = cliente.Execute(pedido);
            
            if (resposta.ErrorException != null)
            {
                MessageBox.Show(resposta.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.escrever("ERRO", resposta.ErrorMessage, resposta.ErrorException.HResult.ToString(), null, null);
            }
            else
            {
                string json = resposta.Content;
                noticias = JsonConvert.DeserializeObject<List<Noticia>>(json);
                listBox_noticias.DataSource = noticias;
                Log.escrever("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);
            }

        }

        private void menu_refresh_Click(object sender, EventArgs e)
        {
            this.OnShown(e);
        }

        private void menu_area_pessoal_Click(object sender, EventArgs e)
        {
            if (username == null)
            {
                new Form_login().ShowDialog();
            }
            else
            {
                abrir_area_pessoal();
            }
        }

        public void menu_terminar_sessao_Click(object sender, EventArgs e)
        {
            cliente = new RestClient(API_URL + "/user/logout");
            pedido = new RestRequest(Method.POST);

            pedido.AddHeader("token", token);

            Log.escrever("Pedido", cliente.BaseUrl.ToString(), pedido.Method.ToString(), pedido.Parameters, null);

            resposta = cliente.Execute(pedido);

            if (resposta.ErrorException != null)
            {
                MessageBox.Show(resposta.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.escrever("ERRO", resposta.ErrorMessage, resposta.ErrorException.HResult.ToString(), null, null);
            }
            else
            {
                token = null;
                username = null;
                menu_terminar_sessao.Visible = false;
                Log.escrever("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);
            }

        }

        public void abrir_area_pessoal()
        {
            new Form_area_pessoal(username, token).ShowDialog();
        }
    }
}
