using BTMobile.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTMobile.Business.Business
{
    public interface IFichaBusiness : IGenericBusiness<Ficha>
    {
        IQueryable<Ficha> Listar(int professorId, int clienteId);
    }
}
