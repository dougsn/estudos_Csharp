using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relacionamento_NxN.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Empregado> Empregados { get; set; }
        public DbSet<Trabalho> Trabalhos{ get; set; }
        public DbSet<EmpregadoTrabalho> EmpregadoTrabalhos{ get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Realizando a vinculação da Tabela NxN com as 2 chaves estrangeiras das outras entidades.
            modelBuilder.Entity<EmpregadoTrabalho>().HasKey(x => new { x.EmpregadoId, x.TrabalhoId });

            


        }



    }

    

}
