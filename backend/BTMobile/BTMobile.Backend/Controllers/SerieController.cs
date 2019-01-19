using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTMobile.Business.Business;
using BTMobile.Business.Entities;
using BTMobile.Business.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTMobile.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        private IGenericBusiness<SerieFicha> business;

        public SerieController()
        {
            this.business = new GenericBusiness<SerieFicha>();
        }

        [HttpGet]
        public ActionResult<IEnumerable<SerieFicha>> Get()
        {
            var lista = business.Listar();
            return lista.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<SerieFicha> Get(int id)
        {
            var serie = business.ObterPorId(id);

            if (serie == null)
                return NotFound();

            return serie;
        }

        [HttpPost]
        public void Post([FromBody] SerieFicha serie)
        {
            business.Incluir(serie);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] SerieFicha serie)
        {
            business.Alterar(serie);
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
