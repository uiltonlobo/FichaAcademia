using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class SerieFicha : BaseEntity
    {
        public SerieFicha()
        {
            this.ExerciciosSerie = new List<ExercicioSerie>();
            this.HistoricoExecucaoSerie = new List<HistoricoExecucaoSerie>();
        }

        public int FichaId { get; set; }
        public string RotuloSerie { get; set; }

        //public virtual Ficha Ficha { get; set; }
        public virtual IEnumerable<ExercicioSerie> ExerciciosSerie { get; set; }
        public virtual IEnumerable<HistoricoExecucaoSerie> HistoricoExecucaoSerie { get; set; }
    }
}
