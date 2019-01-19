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
    public class FichaController : ControllerBase
    {
        private IFichaBusiness business;

        public FichaController()
        {
            this.business = new FichaBusiness();
        }

        public class GetParameters
        {
            public int ProfessorId { get; set; }
            public int ClienteId { get; set; }
        }

        /// <summary>
        /// Obtem as fichas de alunos
        /// </summary>
        /// <param name="parametros">Parametros de busca que podem ser pelo ID do professor e pelo ID do aluno</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Ficha>> Get([FromQuery]GetParameters parametros )
        {
            IEnumerable<Ficha> lista = business.Listar(parametros.ProfessorId, parametros.ClienteId);
            return lista.ToList();
        }


        [HttpGet("{id}")]
        public ActionResult<Ficha> Get(int id)
        {
            var ficha = business.ObterPorId(id);

            if (ficha == null)
                return NotFound();

            return ficha;
        }

        /// <summary>
        /// Gravar dados de uma nova ficha de treino.
        /// </summary>
        /// <param name="ficha"></param>
        [HttpPost]
        public void Post([FromBody] Ficha ficha)
        {
            business.Incluir(ficha);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Ficha ficha)
        {
            business.Alterar(ficha);
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
