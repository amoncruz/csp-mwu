using MWU.Domain.Common;
using System;

namespace MWU.Domain.Entities
{
    public class Integracao : BaseEntity
    {
        public string? Nome { get; set; }
        public string? EndPoint { get; set; }
        public int Periodicidade { get; set; }
        public int IntervaloEmMin { get; set; }
        public DateTime DataInicio { get; set; }
    }
}
