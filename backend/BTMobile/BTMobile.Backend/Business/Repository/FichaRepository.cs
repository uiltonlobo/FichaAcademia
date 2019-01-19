using BTMobile.Business.DB;
using BTMobile.Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTMobile.Business.Repository
{
    public class FichaRepository : GenericRepository<Ficha>, IFichaRepository
    {
        public FichaRepository(BTMobileContext contexto) : base(contexto)
        {
        }

        public override IQueryable<Ficha> Listar()
        {
            var fichas = contexto.Fichas
                .Include(f => f.Professor)
                .Include(f => f.Cliente);
                
            return fichas;
        }

        public override Ficha ObterPorId(int id)
        {
            var ficha = contexto.Fichas
                .Include("Professor")
                .Include("Cliente")
                .Include("Series.ExerciciosSerie.Exercicio")
                .FirstOrDefault(f => f.Id == id);

            return ficha;
        }

        public override void Incluir(Ficha entidade)
        {
            base.Incluir(entidade);
        }
    }
}
