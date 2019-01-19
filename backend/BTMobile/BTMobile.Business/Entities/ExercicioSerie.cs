using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class ExercicioSerie : BaseEntity
    {
        public int Ordem { get; set; }
        public string Repeticao { get; set; }
        public double Carga { get; set; }
        public int SerieFichaId { get; set; }
        public int ExercicioId { get; set; }

        //public virtual SerieFicha SerieFicha { get; set; }
        public virtual Exercicio Exercicio { get; set; }
    }
}
