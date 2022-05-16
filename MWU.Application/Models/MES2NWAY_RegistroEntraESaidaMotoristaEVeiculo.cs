using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWU.Application.Models
{
    public struct MES2NWAY_RegistroEntraESaidaMotoristaEVeiculo
    {
        public string Tipo { get; set; }
        public string Chave { get; set; }
        public string Sentido { get; set; }

        public override string ToString()
        {
            //Tipo(01)
            //Chave(19)
            //Sentido(01)

            return string.Empty;
        }
    }
}
