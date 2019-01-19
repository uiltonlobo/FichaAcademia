using BTMobile.Business.DB;
using BTMobile.Business.Entities;
using BTMobile.Business.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTMobile.Business.Business
{
    public class FichaBusiness : GenericBusiness<Ficha>, IFichaBusiness
    {
        protected BTMobileContext ctx;
        private IFichaRepository fichaRepository;

        public FichaBusiness()
        {
            this.ctx = new BTMobileContext();
            fichaRepository = new FichaRepository(this.ctx);
        }

        public IQueryable<Ficha> Listar(int professorId, int clienteId)
        {
            return fichaRepository.Listar()
                .Where(f => 
                    (professorId > 0 ? f.ProfessorId == professorId : true) &&
                    (clienteId > 0 ? f.ClienteId == clienteId : true));
        }

        public override Ficha ObterPorId(int id)
        {
            return fichaRepository.ObterPorId(id);
        }

        public override void Incluir(Ficha entidade)
        {
            this.fichaRepository.Incluir(entidade);
        }
    }
}
