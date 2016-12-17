using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Windows
{
    public class MODELOS
    {
        public class Noticia
        {
            public int id, autor_id;
            public string titulo, conteudo, imagem;
            public DateTime data_criacao, data_edicao;
            public bool ativo;

            public override string ToString()
            {
                return data_edicao.ToString();
            }
        }

        public class Evento
        {
            public int id, autor_id, concelho_id, estado;
            public string nome, descricao, local, imagem;
            public DateTime data, data_criacao;

            public override string ToString()
            {
                return nome + " (" + data.ToLongDateString() + ")";
            }
        }

        public class Concelho
        {
            public string nome;
            public int id, distrito_id;

            public override string ToString()
            {
                return nome;
            }
        }

        public class Grupo
        {
            public int id, concelho_id;
            public string nome, abreviatura, logo;
            public DateTime data_criacao;

            public override string ToString()
            {
                return nome;
            }
        }

        public class GrupoHistorial
        {
            public int grupo_id;
            public string historial;
            public DateTime data_criacao, data_edicao;

            public override string ToString()
            {
                return historial;
            }
        }
    }
}
