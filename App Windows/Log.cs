using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Windows
{
    class Log
    {
        public static void escrever(string comunicacao, string url_resposta, string metodo_codigo, IList<Parameter> parametros, string body)
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
