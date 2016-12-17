using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using static App_Windows.REST;
using static App_Windows.MODELOS;

namespace App_Windows
{
    public partial class Form_home : Form
    {
        public string token, username;

        RestResponse resposta;
        List<Noticia> noticias;
        List<Evento> eventos;
        List<Grupo> grupos;
        Concelho[] concelhos;
        string[] distritos;

        public Form_home()
        {
            InitializeComponent();
        }

        private void listBox_noticias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_noticias.SelectedIndex >= 0)
            {
                Noticia noticia_selecionada = (Noticia)listBox_noticias.SelectedItem;
                label_noticia_titulo.Text = noticia_selecionada.titulo;
                label_noticia_data.Text = noticia_selecionada.data_criacao.ToString();
                label_noticia_conteudo.Text = noticia_selecionada.conteudo;
            }
        }
        

        private void Form_home_Shown(object sender, EventArgs e)
        {
            tab_SelectedIndexChanged(sender, e);
        }

        private void menu_refresh_Click(object sender, EventArgs e)
        {
            tab_SelectedIndexChanged(sender, e);
        }
        
        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tab.SelectedIndex)
            {
                case 0:
                    //TAB NOTICIAS
                    resposta = REST.ligacao_API_resposta("/noticias", Method.GET, null, null);
                    if (resposta == null)
                    {
                        noticias = null;
                        listBox_noticias.DataSource = null;
                    }
                    else
                    {
                        noticias = JsonConvert.DeserializeObject<List<Noticia>>(resposta.Content);
                        listBox_noticias.DataSource = noticias.OrderByDescending(n => n.data_edicao).ToList();
                    }
                    break;

                case 1:
                    //TAB EVENTOS
                    resposta = REST.ligacao_API_resposta("/eventos", Method.GET, null, null);

                    if (resposta == null)
                    {
                        eventos = null;
                        listBox_eventos.DataSource = null;
                    }
                    else
                    {
                        eventos = JsonConvert.DeserializeObject<List<Evento>>(resposta.Content);
                        listBox_eventos.DataSource = eventos.OrderBy(n => n.data).ToList();
                    }
                    break;

                case 2:
                    //TAB GRUPOS
                    concelhos = REST.obter_concelhos();
                    distritos = REST.obter_distritos();

                    resposta = REST.ligacao_API_resposta("/grupos", Method.GET, null, null);
                    if (resposta == null)
                    {
                        grupos = null;
                        listBox_grupos.DataSource = null;
                    }
                    else
                    {
                        grupos = JsonConvert.DeserializeObject<List<Grupo>>(resposta.Content);
                        listBox_grupos.DataSource = grupos.OrderBy(n => n.nome).ToList();
                    }
                    break;
            }
        }

        private void listBox_eventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_eventos.SelectedIndex >= 0)
            {
                Evento evento_selecionado = (Evento)listBox_eventos.SelectedItem;
                label_evento_titulo.Text = evento_selecionado.nome;
                label_evento_data.Text = evento_selecionado.data.ToString();
                label_evento_local.Text = evento_selecionado.local;
                label_evento_descricao.Text = evento_selecionado.descricao;
            }
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

        public void abrir_area_pessoal()
        {
            new Form_area_pessoal(username, token).ShowDialog();
        }

        private void Form_home_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu_terminar_sessao_Click(sender, e);
        }

        private void listBox_grupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_grupos.SelectedIndex >= 0)
            {
                Grupo grupo_selecionado = (Grupo)listBox_grupos.SelectedItem;
                label_grupo_nome.Text = grupo_selecionado.nome;
                label_grupo_abreviatura.Text = "("+grupo_selecionado.abreviatura+")";
                Concelho concelho = concelhos.Where(c => c.id == grupo_selecionado.concelho_id).First();
                label_grupo_concelho.Text = "Concelho: "+concelho.nome;
                label_grupo_distrito.Text = "Distrito: "+distritos[concelho.distrito_id-1];
            }
        }

        public void menu_terminar_sessao_Click(object sender, EventArgs e)
        {
            List<RestHeader> headers = new List<RestHeader>();
            headers.Add(new RestHeader("token", token));

            RestResponse resposta = ligacao_API_resposta("/user/logout", Method.POST, headers, null);

            if (resposta != null)
            {
                token = null;
                username = null;
                menu_terminar_sessao.Visible = false;
            }
        }
    }
}
