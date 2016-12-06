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

        private void button_login_Click(object sender, EventArgs e)
        {
            if (button_login.Text == "login")
            {
                new Form_login().ShowDialog();
            }
            else
            {
                label_username.Text = "Utilizador: ";
                button_login.Text = "login";
                menu_area_pessoal.Enabled = false;
            }
        }

        public void update_ui(bool estado_botao_menu,string texto_botao_login, string texto_username)
        {
            menu_area_pessoal.Enabled = estado_botao_menu;
            button_login.Text = texto_botao_login;
            label_username.Text = "Utilizador: " + texto_username;
        }

        private void Form_home_Shown(object sender, EventArgs e)
        {
            RestClient cliente = new RestClient("http://localhost/Folclore_API/api/noticias");
            RestRequest request = new RestRequest(Method.GET);

            IRestResponse resposta = cliente.Execute(request);

            //LOG
            log("Pedido",cliente.BaseUrl.ToString(),request.Method.ToString(),request.Parameters,null);
            //

            if (resposta.ErrorException == null)
            {
                string json = cliente.Execute(request).Content;
                noticias = JsonConvert.DeserializeObject<List<Noticia>>(json);
                listBox_noticias.DataSource = noticias;

                //LOG
                log("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);
                //
            }
            else
            {
                MessageBox.Show(resposta.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //LOG
                log("ERRO", resposta.ErrorMessage, resposta.ErrorException.HResult.ToString(), null, null);
                //
            }
        }

        private void menu_refresh_Click(object sender, EventArgs e)
        {
            this.OnShown(e);
        }

        public void log(string comunicacao,string url_resposta, string metodo_codigo, IList<Parameter> parametros, string body)
        {
            string headers = null;
            if (parametros != null)
            {
                foreach (Parameter item in parametros)
                {
                    if (item.Type == ParameterType.HttpHeader)
                    {
                        headers += "\r\n\t\t\t" + item.Name + ": " + item.Value;
                    }
                    else if (item.Type == ParameterType.RequestBody)
                    {
                        body = item.Value.ToString();
                    }
                }
            }

            string linha = "[" + DateTime.Now + "] " + comunicacao + "--> '" + url_resposta + "' (" + metodo_codigo + "):";
            if (headers != null)
            {
                linha += "\r\n\t\t\t--> headers:" + headers;
            }
            if (body != null)
            {
                linha += "\r\n\t\t\t--> body:\r\n\t\t\t" + body;
            }

            StreamWriter escrever = new StreamWriter(Application.StartupPath + "\\log.txt", true);
            escrever.WriteLine(linha);
            escrever.Close();
        }

        
    }
}
