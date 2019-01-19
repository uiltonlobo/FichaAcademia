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
    public class ProfessorController : ControllerBase
    {
        private IGenericBusiness<Professor> business;

        public ProfessorController()
        {
            this.business = new GenericBusiness<Professor>();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Professor>> Get()
        {
            var lista = business.Listar();
            return lista.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Professor> Get(int id)
        {
            var professor = business.ObterPorId(id);

            if (professor == null)
                return NotFound();

            return professor;
        }

        [HttpPost]
        public void Post([FromBody] Professor professor)
        {
            business.Incluir(professor);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Professor professor)
        {
            business.Alterar(professor);
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
