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
    public partial class Form_grupo_informacao : Form
    {
        private string token;

        public Form_grupo_informacao(string token)
        {
            InitializeComponent();
            this.token = token;
        }

        private void Form_grupo_informacao_Shown(object sender, EventArgs e)
        {
            //LISTA DOS DISTRITOS//////////////////////////////////////////////////////////

            RestClient cliente = new RestClient("http://localhost/Folclore_API/api/distritos");
            RestRequest request = new RestRequest(Method.GET);

            //LOG
            Log.escrever("Login", cliente.BaseUrl.ToString(), request.Method.ToString(), request.Parameters, null);
            //

            IRestResponse resposta = cliente.Execute(request);

            if (resposta.ErrorException != null)
            {
                MessageBox.Show(resposta.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //LOG
                Log.escrever("ERRO", resposta.ErrorMessage, resposta.ErrorException.HResult.ToString(), null, null);
                //
            }
            else
            {
                string json = resposta.Content;
                List<string> distritos = JsonConvert.DeserializeObject<List<string>>(json);
                comboBox_distrito.DataSource=distritos;

                //LOG
                Log.escrever("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);
                //
            }



            //LISTA DOS CONCELHOS//////////////////////////////////////////////////////////

            cliente.BaseUrl= new Uri("http://localhost/Folclore_API/api/concelhos");

            //LOG
            Log.escrever("Login", cliente.BaseUrl.ToString(), request.Method.ToString(), request.Parameters, null);
            //

            resposta = cliente.Execute(request);

            if (resposta.ErrorException != null)
            {
                MessageBox.Show(resposta.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //LOG
                Log.escrever("ERRO", resposta.ErrorMessage, resposta.ErrorException.HResult.ToString(), null, null);
                //
            }
            else
            {
                string json = resposta.Content;
                List<string> concelhos = JsonConvert.DeserializeObject<List<string>>(json);
                comboBox_concelho.DataSource = concelhos;

                //LOG
                Log.escrever("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);
                //
            }
        }
    }
}
