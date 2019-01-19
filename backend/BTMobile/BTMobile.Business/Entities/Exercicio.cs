using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class Exercicio : BaseEntity
    {
        public Exercicio()
        {
            //this.ExerciciosSerie = new List<ExercicioSerie>();
        }

        public string Nome { get; set; }

        //public virtual IEnumerable<ExercicioSerie> ExerciciosSerie { get; set; }
    }
}
