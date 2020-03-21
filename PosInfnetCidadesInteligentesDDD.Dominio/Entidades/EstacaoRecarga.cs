using System;

namespace PosInfnetCidadesInteligentesDDD.Dominio.Entidades
{
    public class EstacaoRecarga
    {   
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string TipoEstacao { set; get; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
