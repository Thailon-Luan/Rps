using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChamadosTI.Models.Modelo
{
    //Magica de vincular o objeto com o relacional
    //pura magia
    public class Contexto : DbContext 
    {
        //input classe contexto dentro da classe db context, passando a manipular a classe contexto
        public Contexto(DbContextOptions<Contexto> options): base(options) { }

        public DbSet<Usuario> usuarioContext { get; set; }
        public DbSet<Perifericos> perifericosContext { get; set; }
        public DbSet<Solicitacoes> solicitacoesContext { get; set; }
        public DbSet<Chamados> chamadosContext { get; set; }

    }
}
