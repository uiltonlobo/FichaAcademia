using BTMobile.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BTMobile.Business.Business
{
    public class SerieFichaBusiness : GenericBusiness<SerieFicha>, ISerieFichaBusiness
    {
        public override void Incluir(SerieFicha entidade)
        {
            int qtdSeriesFicha = 0;

            try
            {
                qtdSeriesFicha = this.Listar().Where(s => s.FichaId == entidade.FichaId).Count();

                if (qtdSeriesFicha >= 3)
                {
                    throw new Exception("Só é possível adicionar até 3 séries por ficha.");
                }

                base.Incluir(entidade);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
