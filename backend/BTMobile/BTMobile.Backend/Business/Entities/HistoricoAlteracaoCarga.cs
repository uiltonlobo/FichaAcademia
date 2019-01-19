using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class HistoricoAlteracaoCarga : BaseEntity
    {
        public int ExercicioSerieId { get; set; }
        public DateTime DataHoraAlteracao { get; set; }
        public double NovaCarga { get; set; }

        public virtual ExercicioSerie ExercicioSerie { get; set; }
    }
}
