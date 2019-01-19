using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTMobile.WebAPI.Model
{
    public class ExercicioSerieModel
    {
        public int FichaId { get; set; }
        public int ClienteId { get; set; }
        public int ExercicioSerieId { get; set; }
        public double ValorCarga { get; set; }
    }
}
