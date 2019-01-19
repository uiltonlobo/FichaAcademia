using BTMobile.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTMobile.Business.Business
{
    public interface IGenericBusiness<T> where T : BaseEntity
    {
        void Incluir(T entidade);
        void Alterar(T entidade);
        void Excluir(int id);
        T ObterPorId(int id);
        IQueryable<T> Listar();
    }
}
