using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static App_Windows.MODELOS;

namespace App_Windows
{
    public static class REST
    {
        public static string API_URL = "http://localhost/FolcloreOnline/api";

        public class RestHeader
        {
            public string nome, valor;
            public RestHeader(string nome, string valor)
            {
                this.nome = nome;
                this.valor = valor;
            }
        }

        public static void log(string comunicacao, string url_resposta, string metodo_codigo, IList<Parameter> parametros, string body)
        {
            string headers = null;
            if (parametros != null)
            {
                foreach (Parameter item in parametros)
                {
                    if (item.Type == ParameterType.HttpHeader)
                    {
                        headers += "\r\n\t" + item.Name + ": " + item.Value;
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
                linha += "\r\n--> headers:" + headers;
            }
            if (body != null)
            {
                linha += "\r\n\r\n--> body:\r\n" + JValue.Parse(body).ToString();
            }
            string data = DateTime.Now.ToString("yyyy-MM-dd HH-mm");
            StreamWriter escrever = new StreamWriter(Application.StartupPath + "\\log\\log " + data + ".txt", true);
            escrever.WriteLine(linha + "\r\n\r\n");
            escrever.Close();
        }

        public static string[] obter_distritos()
        {
            RestResponse resposta = ligacao_API_resposta("/distritos", Method.GET, null, null);

            if (resposta == null)
            {
                return null;
            }
            else
            {
                return JsonConvert.DeserializeObject<string[]>(resposta.Content);
            }
            
        }

        public static Concelho[] obter_concelhos()
        {
            RestResponse resposta = ligacao_API_resposta("/concelhos", Method.GET, null, null);

            if (resposta == null)
            {
                return null;
            }
            else
            {
                return JsonConvert.DeserializeObject<Concelho[]>(resposta.Content);
            }
            
        }

        public static Evento obter_evento(int id)
        {
            RestResponse resposta = ligacao_API_resposta("/eventos/" + id, Method.GET, null, null);

            if (resposta == null)
            {
                return null;
            }
            else
            {
                return JsonConvert.DeserializeObject<Evento>(resposta.Content);
            }
        }

        public static string login(string user, string pass)
        {
            List<RestHeader> headers = new List<RestHeader>();
            headers.Add(new RestHeader("username", user));
            headers.Add(new RestHeader("password", pass));
            headers.Add(new RestHeader("dispositivo", "Windows"));

            RestResponse resposta = ligacao_API_resposta("/user/login", Method.POST, headers, null);

            if (devolver_resposta_valida(resposta) == null)
            {
                return null;
            }
            else
            {
                return JObject.Parse(resposta.Content).GetValue("token").ToString();
            }
        }

        public static RestResponse ligacao_API_resposta(string sub_url, Method verbo, List<RestHeader> headers, object body)
        {
            RestClient cliente = new RestClient(API_URL + sub_url);
            RestRequest pedido = new RestRequest(verbo);

            if (headers != null)
            {
                foreach (RestHeader header in headers)
                {
                    pedido.AddHeader(header.nome, header.valor);
                }
            }

            if (body != null)
            {
                //BODY ADICIONADO DESTA FORMA, PARA USAR CONFIGURAÇÕES PERSONALIDAZADAS DO JSON PARA CONVERTER A DATA CORRETAMENTE
                JsonSerializerSettings json_config = new JsonSerializerSettings();
                json_config.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                Parameter param = new Parameter();
                param.Name = "application/json";
                param.Type = ParameterType.RequestBody;
                param.Value = JsonConvert.SerializeObject(body, json_config);

                pedido.AddParameter(param);
            }

            log("Pedido", cliente.BaseUrl.ToString(), pedido.Method.ToString(), pedido.Parameters, null);

            RestResponse resposta = (RestResponse)cliente.Execute(pedido);

            if (resposta.ErrorException != null)
            {
                MessageBox.Show(resposta.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log("ERRO", resposta.ErrorMessage, resposta.ErrorException.HResult.ToString(), null, null);

                return null;
            }
            else
            {
                return resposta;
            }
        }

        public static string devolver_resposta_valida(RestResponse resposta)
        {
            if (resposta == null)
            {
                return null;
            }
            else if (resposta.StatusCode != HttpStatusCode.OK)
            {
                string exception_msg = JObject.Parse(resposta.Content).GetValue("message").ToString();
                MessageBox.Show(exception_msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log("Resposta", exception_msg, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);

                return null;
            }
            else
            {
                log("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);

                return resposta.Content;
            }
        }
    }
}
