using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Windows
{
    class Evento
    {
        public int id, autor_id, concelho_id, estado;
        public string nome, descricao, local, imagem;
        public DateTime data, data_criacao;

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
