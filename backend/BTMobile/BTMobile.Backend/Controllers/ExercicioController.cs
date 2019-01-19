using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTMobile.Business.Business;
using BTMobile.Business.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTMobile.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercicioController : ControllerBase
    {
        private IGenericBusiness<Exercicio> business;

        public ExercicioController()
        {
            this.business = new GenericBusiness<Exercicio>();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Exercicio>> Get()
        {
            var lista = business.Listar();
            return lista.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Exercicio> Get(int id)
        {
            var exercicio = business.ObterPorId(id);

            if (exercicio == null)
            {
                return NotFound();
            }
            return exercicio;
        }

        [HttpPost]
        public void Post([FromBody] Exercicio exercicio)
        {
            business.Incluir(exercicio);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Exercicio exercicio)
        {
            business.Alterar(exercicio);
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
