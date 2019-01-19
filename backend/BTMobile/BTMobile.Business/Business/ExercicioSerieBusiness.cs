using BTMobile.Business.DB;
using BTMobile.Business.Entities;
using BTMobile.Business.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace BTMobile.Business.Business
{
    public class ExercicioSerieBusiness : GenericBusiness<ExercicioSerie>, IExercicioSerieBusiness
    {
        IGenericRepository<ExercicioSerie> exercicioRepository;
        IGenericRepository<HistoricoAlteracaoCarga> historicoRepository;

        public ExercicioSerieBusiness()
        {
            exercicioRepository = new GenericRepository<ExercicioSerie>(contexto);
            historicoRepository = new GenericRepository<HistoricoAlteracaoCarga>(contexto);
        }

        public override void Incluir(ExercicioSerie exercicioSerie)
        {
            int ordem = exercicioRepository.Listar().Max(e => e.Ordem);
            exercicioSerie.Ordem = ordem;

            base.Incluir(exercicioSerie);
        }

        public void AlterarCarga(int fichaId, int clienteId, int exercicioSerieId, double valorCarga)
        {
            //Verificar se o clienteId é o da ficha

            using (TransactionScope scope = new TransactionScope())
            {
                ExercicioSerie exercicio = exercicioRepository.ObterPorId(exercicioSerieId);

                if (exercicio != null)
                {
                    exercicio.Carga = valorCarga;
                    exercicioRepository.Alterar(exercicio);
                }

                HistoricoAlteracaoCarga historico = new HistoricoAlteracaoCarga();
                historico.DataHoraAlteracao = DateTime.Now;
                historico.ExercicioSerieId = exercicioSerieId;
                historico.NovaCarga = valorCarga;

                historicoRepository.Incluir(historico);

                this.contexto.SaveChanges();
                scope.Complete();
            }
        }
    }
}
