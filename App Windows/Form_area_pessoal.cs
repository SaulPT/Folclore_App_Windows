using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace App_Windows
{
    public partial class Form_area_pessoal : Form
    {
        string username, token;
        Grupo grupo_selecionado;
        Concelho[] concelhos;
        string[] distritos;
        Evento evento_selecionado;

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

            List<Grupo> grupos = REST.obter_grupos_administrados(token);
            listBox_grupos.DataSource = grupos;
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
                comboBox_concelho.DataSource = obter_concelho_do_distrito();
            }
        }

        private List<Concelho> obter_concelho_do_distrito()
        {
            //MOSTRA OS CONCELHOS DO DISTRITO SELECIONADO
            List<Concelho> concelhos_do_distrito = new List<Concelho>();
            foreach (Concelho item in concelhos)
            {
                if (item.distrito_id == comboBox_distrito.SelectedIndex + 1)
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
            if (REST.alterar_grupo(token, grupo_selecionado))
            {
                button_editar_Click(sender, e);
            }

            button_concluido.Enabled = true;
        }

        private void button_grupo_evento_adicionar_Click(object sender, EventArgs e)
        {
            button_editar.Text = "Editar";
            button_grupo_evento_editar_Click(sender, e);
            button_editar.Text = "Editar";

            textBox_grupo_evento_nome.Text = "";
            textBox_grupo_evento_local.Text = "";
            textBox_grupo_evento_descricao.Text = "";
            dateTimePicker_grupo_evento_data.Value = DateTime.Now;
            comboBox_grupo_evento_distrito.SelectedIndex = 0;
            comboBox_grupo_evento_concelho.SelectedIndex = 0;
        }

        private void button_grupo_evento_editar_Click(object sender, EventArgs e)
        {
            if (button_editar.Text == "Editar")
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

                tabControl_SelectedIndexChanged(sender, e);
            }
        }

        private void comboBox_grupo_evento_distrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_distrito.SelectedIndex >= 0)
            {
                comboBox_grupo_evento_concelho.DataSource = obter_concelho_do_distrito();
            }
        }

        private void button_grupo_evento_concluido_Click(object sender, EventArgs e)
        {
            button_grupo_evento_concluido.Enabled = false;

            //GUARDA OS NOVOS DADOS NO OBJETO
            Evento novo_evento = new Evento();
            novo_evento.nome = textBox_grupo_evento_nome.Text;
            novo_evento.local = textBox_grupo_evento_local.Text;
            novo_evento.descricao = textBox_grupo_evento_descricao.Text;
            novo_evento.data = dateTimePicker_grupo_evento_data.Value;
            novo_evento.concelho_id=((Concelho)comboBox_grupo_evento_concelho.SelectedItem).id;


            //ENVIA O NOVO EVENTO PARA A API
            if (REST.criar_grupo_evento(token, grupo_selecionado.id,novo_evento))
            {
                button_editar_Click(sender, e);
            }

            button_grupo_evento_concluido.Enabled = true;
        }

        private void listBox_grupo_eventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_grupo_eventos.SelectedIndex >= 0)
            {
                evento_selecionado = (Evento)listBox_grupo_eventos.SelectedItem;
                tabControl_SelectedIndexChanged(sender, e);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    textBox_nome.Text = grupo_selecionado.nome;
                    textBox_abreviatura.Text = grupo_selecionado.abreviatura;
                    comboBox_distrito.DataSource = distritos;
                    comboBox_distrito.SelectedIndex = concelhos[grupo_selecionado.concelho_id - 1].distrito_id - 1;
                    comboBox_concelho.SelectedItem = concelhos[grupo_selecionado.concelho_id - 1];
                    break;

                case 1:
                    //OBTER EVENTOS DO GRUPO
                    List<Evento> grupo_eventos = new List<Evento>();
                    foreach (int grupo_evento_id in REST.obter_grupo_eventos(grupo_selecionado.id))
                    {
                        grupo_eventos.Add(REST.obter_evento(grupo_evento_id));
                    }
                    listBox_grupo_eventos.DataSource = grupo_eventos;

                    if (grupo_eventos.Count>0)
                    {
                        textBox_grupo_evento_nome.Text = evento_selecionado.nome;
                        textBox_grupo_evento_local.Text = evento_selecionado.local;
                        textBox_grupo_evento_descricao.Text = evento_selecionado.descricao;
                        dateTimePicker_grupo_evento_data.Value = evento_selecionado.data;
                        comboBox_grupo_evento_distrito.DataSource = distritos;
                        comboBox_grupo_evento_distrito.SelectedIndex = concelhos[evento_selecionado.concelho_id - 1].distrito_id - 1;
                        comboBox_grupo_evento_concelho.SelectedItem = concelhos[evento_selecionado.concelho_id - 1];
                    }
                    break;
            }
        }

    }
}
