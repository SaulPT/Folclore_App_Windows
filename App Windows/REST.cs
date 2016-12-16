using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    static class REST
    {
        static string API_URL = "http://localhost/FolcloreOnline/api";

        public static void log(string comunicacao, string url_resposta, string metodo_codigo, IList<Parameter> parametros, string body)
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
            escrever.WriteLine(linha + "\r\n");
            escrever.Close();
        }

        public static string[] obter_distritos()
        {
            RestResponse resposta = ligacao_API_resposta("/distritos", Method.GET, null, null);

            if (resposta == null)
                return null;
            else
                return JsonConvert.DeserializeObject<string[]>(resposta.Content);
        }

        public static Concelho[] obter_concelhos()
        {
            RestResponse resposta = ligacao_API_resposta("/concelhos", Method.GET, null, null);

            if (resposta == null)
                return null;
            else
                return JsonConvert.DeserializeObject<Concelho[]>(resposta.Content);
        }

        public static List<Noticia> obter_noticias()
        {
            RestResponse resposta = ligacao_API_resposta("/noticias", Method.GET, null, null);

            if (resposta == null)
                return null;
            else
                return JsonConvert.DeserializeObject<List<Noticia>>(resposta.Content);
        }

        public static List<Evento> obter_eventos()
        {
            RestResponse resposta = ligacao_API_resposta("/eventos", Method.GET, null, null);

            if (resposta == null)
                return null;
            else
                return JsonConvert.DeserializeObject<List<Evento>>(resposta.Content);
        }

        public static Evento obter_evento(int id)
        {
            RestResponse resposta = ligacao_API_resposta("/eventos/"+id, Method.GET, null, null);

            if (resposta == null)
                return null;
            else
                return JsonConvert.DeserializeObject<Evento>(resposta.Content);
        }

        public static List<Grupo> obter_grupos()
        {
            RestResponse resposta = ligacao_API_resposta("/grupos", Method.GET, null, null);

            if (resposta == null)
                return null;
            else
                return JsonConvert.DeserializeObject<List<Grupo>>(resposta.Content);
        }

        public static Grupo obter_grupo(int id)
        {
            RestResponse resposta = ligacao_API_resposta("/grupos/"+id, Method.GET, null, null);

            if (resposta == null)
                return null;
            else
                return JsonConvert.DeserializeObject<Grupo>(resposta.Content);
        }

        public static string login(string user, string pass)
        {
            string[,] headers = new string[3, 2] { { "username", user }, { "password", pass }, { "dispositivo", "Windows" } };

            RestResponse resposta = ligacao_API_resposta("/user/login", Method.POST, headers, null);

            if (resposta == null)
            {
                return null;
            }
            else if (resposta.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(resposta.StatusDescription, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                return JObject.Parse(resposta.Content).Property("token").Value.ToString();
            }
        }
        
        public static bool terminar_sessao(string token)
        {
            string[,] headers = { { "token", token } };
            RestResponse resposta = ligacao_API_resposta("/user/logout", Method.POST, headers, null);

            if (resposta== null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static List<Grupo> obter_grupos_administrados(string token)
        {
            string[,] headers = { { "token", token } };
            RestResponse resposta = ligacao_API_resposta("/user/grupos", Method.GET, headers, null);

            if (resposta == null)
            {
                return null;
            }
            else if (resposta.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(resposta.StatusDescription, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                return JsonConvert.DeserializeObject<List<Grupo>>(resposta.Content);
            }
        }

        public static bool alterar_grupo(string token, Grupo grupo_selecionado)
        {
            string[,] headers = { { "token", token } };

            //BODY ADICIONADO DESTA FORMA, PARA USAR CONFIGURAÇÕES PERSONALIDAZADAS DO JSON PARA CONVERTER A DATA CORRETAMENTE
            JsonSerializerSettings json_config = new JsonSerializerSettings();
            json_config.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            Parameter body = new Parameter();
            body.Name = "application/json";
            body.Type = ParameterType.RequestBody;
            body.Value = JsonConvert.SerializeObject(grupo_selecionado, json_config);

            RestResponse resposta = ligacao_API_resposta("/grupos/" + grupo_selecionado.id, Method.PUT, headers, body);

            if (resposta == null)
            {
                return false;
            }
            else if (resposta.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(resposta.StatusDescription, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }

        public static int[] obter_grupo_eventos(int grupo_id)
        {
            string[,] headers = { { "grupo_id", grupo_id.ToString() } };

            RestResponse resposta = ligacao_API_resposta("/grupo/eventos", Method.GET, headers, null);

            if (resposta == null)
            {
                return null;
            }
            else
            {
                return JsonConvert.DeserializeObject<int[]>(resposta.Content);
            }
        }

        
        public static bool criar_grupo_evento(string token, int grupo_id, Evento evento)
        {
            string[,] headers = { { "token", token },{ "grupo_id", grupo_id.ToString() } };

            //BODY ADICIONADO DESTA FORMA, PARA USAR CONFIGURAÇÕES PERSONALIDAZADAS DO JSON PARA CONVERTER A DATA CORRETAMENTE
            JsonSerializerSettings json_config = new JsonSerializerSettings();
            json_config.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            json_config.NullValueHandling = NullValueHandling.Ignore;
            Parameter body = new Parameter();
            body.Name = "application/json";
            body.Type = ParameterType.RequestBody;
            body.Value = JsonConvert.SerializeObject(evento, json_config);

            RestResponse resposta = ligacao_API_resposta("/grupo/eventos", Method.POST, headers, body);

            if (resposta == null)
            {
                return false;
            }
            else if (resposta.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(resposta.StatusDescription, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }


        public static RestResponse ligacao_API_resposta(string sub_url, Method verbo, string[,] headers, Parameter body)
        {
            RestClient cliente = new RestClient(API_URL + sub_url);
            RestRequest pedido = new RestRequest(verbo);

            if (headers != null)
            {
                for (int x = 0; x < headers.GetLength(0); x++)
                {
                    pedido.AddHeader(headers[x, 0], headers[x, 1]);
                }
            }

            if (body != null)
            {
                pedido.AddParameter(body);
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
                log("Resposta", resposta.StatusDescription, ((int)resposta.StatusCode).ToString(), resposta.Headers, resposta.Content);

                return resposta;
            }
        }
    }
}
