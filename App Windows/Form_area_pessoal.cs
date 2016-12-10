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
    public partial class Form_area_pessoal : Form
    {
        string username,token;

        public Form_area_pessoal(string username,string token)
        {
            InitializeComponent();
            this.username = username;
            this.token = token;
        }

        private void button_historial_Click(object sender, EventArgs e)
        {
            
        }
    }
}
