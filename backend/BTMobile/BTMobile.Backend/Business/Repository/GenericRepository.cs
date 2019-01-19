using BTMobile.Business.DB;
using BTMobile.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTMobile.Business.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected BTMobileContext contexto;

        public GenericRepository(BTMobileContext contexto)
        {
            this.contexto = contexto;
        }

        public virtual void Alterar(T entidade)
        {
            contexto.Entry(entidade).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public virtual void Excluir(T entidade)
        {
            contexto.Set<T>().Remove(entidade);
        }

        public virtual void Incluir(T entidade)
        {
            contexto.Set<T>().Add(entidade);
        }

        public virtual IQueryable<T> Listar()
        {
            return contexto.Set<T>();
        }

        public virtual T ObterPorId(int id)
        {
            return contexto.Set<T>().Find(id);
        }

        public virtual void SaveChanges()
        {
            contexto.SaveChanges();
        }
    }
}
