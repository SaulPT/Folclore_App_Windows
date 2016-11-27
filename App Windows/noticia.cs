using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Windows
{
    class Noticia
    {
        public int id, autor_id;
        public string titulo, conteudo, imagem;
        public DateTime data_criacao, data_edicao;
        public bool ativo;

        public override string ToString()
        {
            return data_criacao.ToString();
        }
    }
}
