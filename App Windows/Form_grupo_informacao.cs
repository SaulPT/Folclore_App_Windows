using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class Form_grupo_informacao : Form
    {
        private string token;
        private Grupo grupo;
        private Concelho[] concelhos;
        private string[] distritos;
        private RestClient cliente;
        private RestRequest pedido;
        private IRestResponse resposta;

        public Form_grupo_informacao(string token, Grupo grupo)
        {
            InitializeComponent();
            this.token = token;
            this.grupo = grupo;
        }

        private void Form_grupo_informacao_Shown(object sender, EventArgs e)
        {
            //OBTÉM LISTA DOS DISTRITOS//////////////////////////////////////////////////////////

            cliente = new RestClient(Form_home.API_URL + "/distritos");
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
                distritos = JsonConvert.DeserializeObject<string[]>(json);
                Log.escrever("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);
            }



            //OBTÉM LISTA DOS CONCELHOS//////////////////////////////////////////////////////////

            cliente = new RestClient(Form_home.API_URL + "/concelhos");
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
                concelhos = JsonConvert.DeserializeObject<Concelho[]>(json);
                Log.escrever("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);
            }



            //MOSTRA OS DADOS DO GRUPO//////////////////////////////////////////////////////////////////////////////
            textBox_nome.Text = grupo.nome;
            textBox_abreviatura.Text = grupo.abreviatura;
            comboBox_distrito.DataSource = distritos;
            comboBox_distrito.SelectedIndex = concelhos[grupo.concelho_id - 1].distrito_id - 1;
            comboBox_concelho.SelectedItem = concelhos[grupo.concelho_id - 1];
        }

        private void comboBox_distrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MOSTRA OS CONCELHOS DO DISTRITO SELECIONADO
            if (comboBox_distrito.SelectedIndex >= 0)
            {
                List<Concelho> concelhos_do_distrito = new List<Concelho>();
                foreach (Concelho item in concelhos)
                {
                    if (item.distrito_id == comboBox_distrito.SelectedIndex + 1)
                    {
                        concelhos_do_distrito.Add(item);
                    }
                }

                concelhos_do_distrito = concelhos_do_distrito.OrderBy(c => c.nome).ToList();
                comboBox_concelho.DataSource = concelhos_do_distrito;
            }
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
            }
        }

        private void button_concluido_Click(object sender, EventArgs e)
        {
            button_concluido.Enabled = false;

            //GUARDA OS NOVOS DADOS NO OBJETO
            grupo.nome = textBox_nome.Text;
            grupo.abreviatura = textBox_abreviatura.Text;
            grupo.concelho_id = ((Concelho)comboBox_concelho.SelectedItem).id;


            //ENVIA O NOVO GRUPO PARA A API

            cliente = new RestClient(Form_home.API_URL + "/grupos/" + grupo.id);
            pedido = new RestRequest(Method.PUT);

            pedido.AddHeader("token", token);

            //pedido.JsonSerializer.DateFormat = "g";
            //pedido.AddJsonBody(grupo);
            JsonSerializerSettings json_config = new JsonSerializerSettings();
            json_config.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            pedido.AddParameter("application/json", JsonConvert.SerializeObject(grupo, json_config), ParameterType.RequestBody);
            
            Log.escrever("Pedido", cliente.BaseUrl.ToString(), pedido.Method.ToString(), pedido.Parameters, null);
            
            resposta = cliente.Execute(pedido);

            if (resposta.ErrorException != null)
            {
                MessageBox.Show(resposta.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.escrever("ERRO", resposta.ErrorMessage, resposta.ErrorException.HResult.ToString(), null, null);
            }
            else
            {
                Log.escrever("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);

                if (resposta.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(resposta.StatusDescription, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button_concluido.Enabled = true;
                }
                else
                {
                    ((Form_area_pessoal)Application.OpenForms[1]).Form_area_pessoal_Shown(sender, e);
                    this.Close();
                }
            }
        }
    }
}
