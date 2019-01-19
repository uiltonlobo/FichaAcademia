using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class Cliente : BaseEntity
    {
        public Cliente()
        {
            //this.Fichas = new List<Ficha>();
        }

        public string Nome { get; set; }

        //public virtual IEnumerable<Ficha> Fichas { get; set; }
        
    }
}
