using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChamadosTI.Models.Modelo
{
    public class Usuario
    {
       
        public int id { get; set; }
        public string nomeUsuario { get; set; }
        public string maquinaUsuario { get; set; }
        public string setorUsuario { get; set; }

        //lembrar da relação do usuario com demais eventos
        //um usuario pode ter demais eventos 1/N

        public ICollection<Chamados> chamados{ get; set; }
        //relacionamento entre usuario e chamados

        public ICollection<Solicitacoes> solicitacoes { get; set; }


    }
}
