using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class Contrato : BaseEntity
    {
        public int ClienteId { get; set; }
        public bool Ativo { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
