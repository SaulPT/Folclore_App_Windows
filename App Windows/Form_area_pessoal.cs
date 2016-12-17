using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using static App_Windows.REST;
using static App_Windows.MODELOS;

namespace App_Windows
{
    public partial class Form_area_pessoal : Form
    {
        string username, token;

        RestResponse resposta;
        List<RestHeader> headers;
        Grupo grupo_selecionado;
        Concelho[] concelhos;
        string[] distritos;
        Evento evento_selecionado;
        GrupoHistorial grupo_historial;

        public Form_area_pessoal(string username, string token)
        {
            InitializeComponent();
            this.username = username;
            this.token = token;
        }

        private void Form_area_pessoal_Load(object sender, EventArgs e)
        {
            label_username.Text = username;
            dateTimePicker_grupo_evento_data.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker_grupo_evento_data.Format = DateTimePickerFormat.Custom;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            ((Form_home)Application.OpenForms[0]).menu_terminar_sessao_Click(sender, e);
            this.Close();
        }

        public void Form_area_pessoal_Shown(object sender, EventArgs e)
        {
            distritos = REST.obter_distritos();
            concelhos = REST.obter_concelhos();


            headers = new List<RestHeader>();
            headers.Add(new RestHeader("token", token));
            resposta = ligacao_API_resposta("/user/grupos", Method.GET, headers, null);
            if (devolver_resposta_valida(resposta) == null)
            {
                listBox_grupos.DataSource = null;
            }
            else
            {
                listBox_grupos.DataSource = JsonConvert.DeserializeObject<List<Grupo>>(resposta.Content);
            }
            
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Form_area_pessoal_Shown(sender, e);
        }

        private void listBox_grupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_grupos.SelectedIndex >= 0)
            {
                grupo_selecionado = (Grupo)listBox_grupos.SelectedItem;
                tabControl_SelectedIndexChanged(sender, e);
            }
        }

        private void comboBox_distrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_distrito.SelectedIndex >= 0)
            {
                comboBox_concelho.DataSource = obter_concelho_do_distrito(false);
            }
        }

        private List<Concelho> obter_concelho_do_distrito(bool eventos)
        {
            //MOSTRA OS CONCELHOS DO DISTRITO SELECIONADO

            int index;
            if (eventos)
            {
                index = comboBox_grupo_evento_distrito.SelectedIndex;
            }
            else
            {
                index = comboBox_distrito.SelectedIndex;
            }
            
            List<Concelho> concelhos_do_distrito = new List<Concelho>();
            foreach (Concelho item in concelhos)
            {
                if (item.distrito_id == index + 1)
                {
                    concelhos_do_distrito.Add(item);
                }
            }

            return concelhos_do_distrito.OrderBy(c => c.nome).ToList();
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            if (button_editar.Text == "Editar")
            {
                textBox_nome.Enabled = true;
                textBox_abreviatura.Enabled = true;
                comboBox_distrito.Enabled = true;
                comboBox_concelho.Enabled = true;
                button_editar.Text = "Cancelar";
                button_concluido.Enabled = true;
            }
            else
            {
                textBox_nome.Enabled = false;
                textBox_abreviatura.Enabled = false;
                comboBox_distrito.Enabled = false;
                comboBox_concelho.Enabled = false;
                button_editar.Text = "Editar";
                button_concluido.Enabled = false;

                tabControl_SelectedIndexChanged(sender, e);
            }
        }

        private void button_concluido_Click(object sender, EventArgs e)
        {
            button_concluido.Enabled = false;

            //GUARDA OS NOVOS DADOS NO OBJETO
            grupo_selecionado.nome = textBox_nome.Text;
            grupo_selecionado.abreviatura = textBox_abreviatura.Text;
            grupo_selecionado.concelho_id = ((Concelho)comboBox_concelho.SelectedItem).id;


            //ENVIA O NOVO GRUPO PARA A API
            headers = new List<RestHeader>();
            headers.Add(new RestHeader("token", token));

            resposta = ligacao_API_resposta("/grupos/" + grupo_selecionado.id, Method.PUT, headers, grupo_selecionado);

            button_concluido.Enabled = true;
            if (devolver_resposta_valida(resposta) != null)
            {
                button_editar_Click(sender, e);
            }
        }

        private void button_grupo_evento_adicionar_Click(object sender, EventArgs e)
        {
            if (button_grupo_evento_adicionar.Text == "Adicionar")
            {
                textBox_grupo_evento_nome.Enabled = true;
                textBox_grupo_evento_local.Enabled = true;
                textBox_grupo_evento_descricao.Enabled = true;
                dateTimePicker_grupo_evento_data.Enabled = true;
                comboBox_grupo_evento_distrito.Enabled = true;
                comboBox_grupo_evento_concelho.Enabled = true;
                button_grupo_evento_adicionar.Text = "Cancelar";
                button_grupo_evento_concluido.Enabled = true;
                button_grupo_evento_editar.Enabled = false;
                button_grupo_evento_eliminar.Enabled = false;
                listBox_grupo_eventos.Enabled = false;

                textBox_grupo_evento_nome.Text = "";
                textBox_grupo_evento_local.Text = "";
                textBox_grupo_evento_descricao.Text = "";
                dateTimePicker_grupo_evento_data.Value = DateTime.Now;
                comboBox_grupo_evento_distrito.SelectedIndex = 0;
                comboBox_grupo_evento_concelho.SelectedIndex = 0;
            }
            else
            {
                textBox_grupo_evento_nome.Enabled = false;
                textBox_grupo_evento_local.Enabled = false;
                textBox_grupo_evento_descricao.Enabled = false;
                dateTimePicker_grupo_evento_data.Enabled = false;
                comboBox_grupo_evento_distrito.Enabled = false;
                comboBox_grupo_evento_concelho.Enabled = false;
                button_grupo_evento_adicionar.Text = "Adicionar";
                button_grupo_evento_concluido.Enabled = false;
                button_grupo_evento_editar.Enabled = true;
                button_grupo_evento_eliminar.Enabled = true;
                listBox_grupo_eventos.Enabled = true;

                listBox_grupo_eventos_SelectedIndexChanged(sender, e);
            }
        }

        private void button_grupo_evento_editar_Click(object sender, EventArgs e)
        {
            if (button_grupo_evento_editar.Text == "Editar")
            {
                textBox_grupo_evento_nome.Enabled = true;
                textBox_grupo_evento_local.Enabled = true;
                textBox_grupo_evento_descricao.Enabled = true;
                dateTimePicker_grupo_evento_data.Enabled = true;
                comboBox_grupo_evento_distrito.Enabled = true;
                comboBox_grupo_evento_concelho.Enabled = true;
                button_grupo_evento_editar.Text = "Cancelar";
                button_grupo_evento_concluido.Enabled = true;
                button_grupo_evento_adicionar.Enabled = false;
                button_grupo_evento_eliminar.Enabled = false;
                listBox_grupo_eventos.Enabled = false;
            }
            else
            {
                textBox_grupo_evento_nome.Enabled = false;
                textBox_grupo_evento_local.Enabled = false;
                textBox_grupo_evento_descricao.Enabled = false;
                dateTimePicker_grupo_evento_data.Enabled = false;
                comboBox_grupo_evento_distrito.Enabled = false;
                comboBox_grupo_evento_concelho.Enabled = false;
                button_grupo_evento_editar.Text = "Editar";
                button_grupo_evento_concluido.Enabled = false;
                button_grupo_evento_adicionar.Enabled = true;
                button_grupo_evento_eliminar.Enabled = true;
                listBox_grupo_eventos.Enabled = true;

                listBox_grupo_eventos_SelectedIndexChanged(sender, e);
            }
        }

        private void comboBox_grupo_evento_distrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_distrito.SelectedIndex >= 0)
            {
                comboBox_grupo_evento_concelho.DataSource = obter_concelho_do_distrito(true);
            }
        }

        private void button_grupo_evento_concluido_Click(object sender, EventArgs e)
        {
            button_grupo_evento_concluido.Enabled = false;

            
            Evento novo_evento;
            Method metodo;
            if (button_grupo_evento_adicionar.Enabled)
            {
                //CRIA UM NOVO EVENTO
                metodo = Method.POST;
                novo_evento = new Evento();
            }
            else
            {
                //ATUALIZA UM EVENTO
                metodo = Method.PUT;
                novo_evento = (Evento)listBox_grupo_eventos.SelectedItem;
            }
            novo_evento.nome = textBox_grupo_evento_nome.Text;
            novo_evento.local = textBox_grupo_evento_local.Text;
            novo_evento.descricao = textBox_grupo_evento_descricao.Text;
            novo_evento.data = dateTimePicker_grupo_evento_data.Value;
            novo_evento.concelho_id = ((Concelho)comboBox_grupo_evento_concelho.SelectedItem).id;

            headers = new List<RestHeader>();
            headers.Add(new RestHeader("token", token));
            headers.Add(new RestHeader("grupo_id", grupo_selecionado.id.ToString()));
            resposta = ligacao_API_resposta("/grupo/eventos", metodo, headers, novo_evento);

            if (devolver_resposta_valida(resposta) == null)
            {
                button_grupo_evento_concluido.Enabled = true;
            }
            else
            {
                int grupo_index = listBox_grupos.SelectedIndex;
                button_refresh_Click(sender, e);
                listBox_grupos.SelectedIndex = grupo_index;
                if (button_grupo_evento_adicionar.Text == "Cancelar")
                {
                    button_grupo_evento_adicionar_Click(sender, e);
                }
                else
                {
                    button_grupo_evento_editar_Click(sender, e);
                }
            }
        }

        private void listBox_grupo_eventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_grupo_eventos.SelectedIndex >= 0)
            {
                evento_selecionado = (Evento)listBox_grupo_eventos.SelectedItem;

                textBox_grupo_evento_nome.Text = evento_selecionado.nome;
                textBox_grupo_evento_local.Text = evento_selecionado.local;
                textBox_grupo_evento_descricao.Text = evento_selecionado.descricao;
                dateTimePicker_grupo_evento_data.Value = evento_selecionado.data;
                comboBox_grupo_evento_distrito.DataSource = distritos;
                comboBox_grupo_evento_distrito.SelectedIndex = concelhos[evento_selecionado.concelho_id - 1].distrito_id - 1;
                comboBox_grupo_evento_concelho.SelectedItem = concelhos[evento_selecionado.concelho_id - 1];
            }
        }

        private void button_grupo_historial_eliminar_Click(object sender, EventArgs e)
        {
            string historial_antigo = grupo_historial.historial;

            headers = new List<RestHeader>();
            headers.Add(new RestHeader("token", token));
            resposta = REST.ligacao_API_resposta("/grupohistorials/" + grupo_historial.grupo_id, Method.DELETE, headers, null);

            if (devolver_resposta_valida(resposta) == null)
            {
                textBox_grupo_historial.Text = historial_antigo;
            }
            else
            {
                textBox_grupo_historial.Text = null;
            }
        }

        private void button_grupo_historial_editar_Click(object sender, EventArgs e)
        {
            string historial_antigo = grupo_historial.historial;

            grupo_historial.data_edicao = DateTime.Now;
            grupo_historial.historial = textBox_grupo_historial.Text;

            headers = new List<RestHeader>();
            headers.Add(new RestHeader("token", token));
            resposta = REST.ligacao_API_resposta("/grupohistorials/" + grupo_historial.grupo_id, Method.PUT, headers, grupo_historial);

            if (devolver_resposta_valida(resposta) == null)
            {
                textBox_grupo_historial.Text = historial_antigo;
            }
        }

        private void button_grupo_evento_eliminar_Click(object sender, EventArgs e)
        {
            headers = new List<RestHeader>();
            headers.Add(new RestHeader("token", token));
            headers.Add(new RestHeader("grupo_id", grupo_selecionado.id.ToString()));
            headers.Add(new RestHeader("evento_id", evento_selecionado.id.ToString()));
            resposta = ligacao_API_resposta("/grupo/eventos", Method.DELETE, headers, null);

            if (devolver_resposta_valida(resposta) != null)
            {
                int grupo_index = listBox_grupos.SelectedIndex;
                button_refresh_Click(sender, e);
                listBox_grupos.SelectedIndex = grupo_index;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    //INFORMAÇÃO DO GRUPO
                    textBox_nome.Text = grupo_selecionado.nome;
                    textBox_abreviatura.Text = grupo_selecionado.abreviatura;
                    comboBox_distrito.DataSource = distritos;
                    comboBox_distrito.SelectedIndex = concelhos[grupo_selecionado.concelho_id - 1].distrito_id - 1;
                    comboBox_concelho.SelectedItem = concelhos[grupo_selecionado.concelho_id - 1];
                    break;

                case 1:
                    //OBTER ID's DOS EVENTOS PERTENCENTES AO GRUPO
                    headers = new List<RestHeader>();
                    headers.Add(new RestHeader("grupo_id", grupo_selecionado.id.ToString()));
                    resposta = ligacao_API_resposta("/grupo/eventos", Method.GET, headers, null);
                    int[] grupo_eventos_ids;
                    if (resposta == null)
                    {
                        grupo_eventos_ids= null;
                    }
                    else
                    {
                        grupo_eventos_ids = JsonConvert.DeserializeObject<int[]>(resposta.Content);
                    }

                    //OBTER EVENTOS COM OS ID's OBTIDOS
                    List<Evento> grupo_eventos = new List<Evento>();
                    foreach (int grupo_evento_id in grupo_eventos_ids)
                    {
                        grupo_eventos.Add(obter_evento(grupo_evento_id));
                    }
                    listBox_grupo_eventos.DataSource = grupo_eventos;


                    if (grupo_eventos.Count == 0)
                    {
                        button_grupo_evento_editar.Enabled = false;
                        button_grupo_evento_eliminar.Enabled = false;
                    }
                    else
                    {
                        button_grupo_evento_editar.Enabled = true;
                        button_grupo_evento_eliminar.Enabled = true;
                    }
                    break;

                case 2:
                    //OBTER HISTORIAL DO GRUPO
                    resposta = REST.ligacao_API_resposta("/grupohistorials/" + grupo_selecionado.id, Method.GET, null, null);

                    if (resposta != null)
                    {
                        grupo_historial = JsonConvert.DeserializeObject<GrupoHistorial>(resposta.Content);
                        textBox_grupo_historial.Text = grupo_historial.historial;
                    }
                    else
                    {
                        grupo_historial = null;
                    }
                    break;
            }
        }

    }
}
