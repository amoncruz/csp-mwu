
using MWU.Application.Common;
using System;

namespace MWU.Application.DTO.Integracao
{
    public class IntegracaoDTO : BaseDTO
    {
        public string Nome { get; set; }
        public string EndPoint { get; set; }
        public int Periodicidade { get; set; }
        public int IntervaloEmMin { get; set; }
        public DateTime DataInicio { get; set; }

        public IntegracaoDTO(string Nome, string EndPoint)
        {
            this.Nome = Nome;
            this.EndPoint = EndPoint;
        }
    }
}
