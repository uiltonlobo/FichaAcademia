using BTMobile.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTMobile.Business.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        void Incluir(T entidade);
        void Alterar(T entidade);
        void Excluir(T entidade);
        T ObterPorId(int id);
        IQueryable<T> Listar();
        void SaveChanges();
    }
}
