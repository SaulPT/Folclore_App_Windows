﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Windows
{
    public class Grupo
    {
        public int id,concelho_id;
        public string nome,abreviatura,logo;
        public DateTime data_criacao;

        public override string ToString()
        {
            return nome;
        }
    }
}
