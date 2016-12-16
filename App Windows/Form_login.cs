using System;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace App_Windows
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            button_login.Enabled = false;

            string token = REST.login(textBox_username.Text, textBox_password.Text);
            if (token == null)
            {
                button_login.Enabled = true;
            }
            else
            {
                Form_home form_inicial = (Form_home)Application.OpenForms[0];
                form_inicial.token = token;
                form_inicial.username = textBox_username.Text;
                form_inicial.menu_terminar_sessao.Visible = true;

                this.Visible = false;
                this.Close();

                form_inicial.abrir_area_pessoal();
            }
        }

        private void textBox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
