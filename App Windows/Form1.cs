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

namespace App_Windows
{
    public partial class Form1 : Form
    {
        List<Noticia> noticias;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RestClient cliente = new RestClient("http://localhost/noticias");
            RestRequest request = new RestRequest(Method.GET);

            /*
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            */

            string json = cliente.Execute(request).Content;
            noticias = JsonConvert.DeserializeObject<List<Noticia>>(json);

            listBox_noticias.DataSource = noticias;

            //utilizadores = JsonConvert.DeserializeObject<List<Utilizador>>(json);
        }

        private void listBox_noticias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Noticia noticia_selecionada = noticias.Find(n => n == listBox_noticias.SelectedItem);
            label_titulo.Text = noticia_selecionada.titulo;
            label_data.Text = noticia_selecionada.data_criacao.ToString();
            label_conteudo.Text = noticia_selecionada.conteudo;
        }
    }
}
