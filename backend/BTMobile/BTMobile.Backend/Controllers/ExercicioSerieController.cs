using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTMobile.Business.Business;
using BTMobile.Business.Entities;
using BTMobile.Business.Repository;
using BTMobile.WebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTMobile.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercicioSerieController : ControllerBase
    {
        private IExercicioSerieBusiness business;

        public ExercicioSerieController()
        {
            this.business = new ExercicioSerieBusiness();
        }

        [HttpGet]
        public ActionResult<IEnumerable<ExercicioSerie>> Get()
        {
            var lista = business.Listar();
            return lista.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<ExercicioSerie> Get(int id)
        {
            var exercicioSerie = business.ObterPorId(id);

            if (exercicioSerie == null)
                return NotFound();

            return exercicioSerie;
        }

        [HttpPost]
        public void Post([FromBody] ExercicioSerie exercicioSerie)
        {
            business.Incluir(exercicioSerie);
        }

        [HttpPut("{fichaId}")]
        public IActionResult Put(int fichaId, [FromBody]ExercicioSerieModel exercicio)
        {
            business.AlterarCarga(exercicio.FichaId, exercicio.ClienteId, exercicio.ExercicioSerieId, exercicio.ValorCarga);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            business.Excluir(id);
            return NoContent();
        }
    }
}
