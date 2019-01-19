using BTMobile.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Business
{
    public interface IExercicioSerieBusiness : IGenericBusiness<ExercicioSerie>
    {
        void AlterarCarga(int fichaId, int clienteId, int exercicioSerieId, double valorCarga);
    }
}
