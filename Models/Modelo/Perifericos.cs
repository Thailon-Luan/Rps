using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChamadosTI.Models.Modelo
{
   
    public class Perifericos
    {
        public int id { get; set; }
        public string nomePerifericos { get; set; }
        public string especificacaoPerifericos { get; set; }
        public float quantidadePerifericos { get; set; }

        public ICollection<Solicitacoes> SolicitacoesPerifericos { get; set; }
        
    }
}
