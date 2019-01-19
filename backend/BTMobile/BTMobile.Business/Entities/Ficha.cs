using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class Ficha : BaseEntity
    {
        public Ficha()
        {
            this.Series = new List<SerieFicha>();
        }

        public int ProfessorId { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataCriacao { get; set; }

        public virtual Professor Professor { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual IEnumerable<SerieFicha> Series { get; set; }
    }
}
