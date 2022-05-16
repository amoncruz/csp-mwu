using System;
using System.Collections.Generic;
using System.Text;

namespace MWU.CLR
{
    public struct NWAY2MES_IdentificacaoVeiculoEMotorista
    {
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Chave { get; set; }
        public string Ativo { get; set; }
        public string Modelo { get; set; }
        public string Tag_Veicular { get; set; }

        public override string ToString()
        {
            //Tipo(01)
            //Nome(50)
            //Chave(19)
            //Ativo(01)
            //Modelo(50)
            //Tag_Veicular(30)
            return string.Empty;
        }
    }
}
