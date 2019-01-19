using BTMobile.Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.DB
{
    public class BTMobileContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<ExercicioSerie> ExerciciosSerie { get; set; }
        public DbSet<Ficha> Fichas { get; set; }
        public DbSet<HistoricoAlteracaoCarga> HistoricoAlteracaoCarga { get; set; }
        public DbSet<HistoricoExecucaoSerie> HistoricoExecucaoSerie { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<SerieFicha> SeriesFicha { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=.\SQLEXPRESS;Database=BTMobileDB;User ID=sa;Password=sqlex123;Trusted_Connection=False;");
        }
    }
}
