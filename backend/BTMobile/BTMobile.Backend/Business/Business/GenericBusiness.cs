using BTMobile.Business.DB;
using BTMobile.Business.Entities;
using BTMobile.Business.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTMobile.Business.Business
{
    public class GenericBusiness<T> : IGenericBusiness<T> where T : BaseEntity
    {
        protected BTMobileContext contexto;
        protected IGenericRepository<T> repositorio;

        public GenericBusiness()
        {
            this.contexto = new BTMobileContext();
            this.repositorio = new GenericRepository<T>(this.contexto);
        }

        public virtual void Alterar(T entidade)
        {
            this.repositorio.Alterar(entidade);
            this.repositorio.SaveChanges();
        }

        public virtual void Excluir(int id)
        {
            var entidadeAtual = this.repositorio.ObterPorId(id);
            if (entidadeAtual == null)
                throw new Exception();

            this.repositorio.Excluir(entidadeAtual);
            this.repositorio.SaveChanges();
        }

        public virtual void Incluir(T entidade)
        {
            this.repositorio.Incluir(entidade);
            this.repositorio.SaveChanges();
        }

        public virtual IQueryable<T> Listar()
        {
            return this.repositorio.Listar();
        }

        public virtual T ObterPorId(int id)
        {
            return this.repositorio.ObterPorId(id);
        }
    }
}
