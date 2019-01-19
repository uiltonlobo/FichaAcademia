using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTMobile.Business.Business;
using BTMobile.Business.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BTMobile.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerieFichaController : Controller
    {
        private ISerieFichaBusiness business;

        public SerieFichaController()
        {
            business = new SerieFichaBusiness();
        }

        [HttpPost]
        public IActionResult Post([FromBody] SerieFicha ficha)
        {
            try
            {
                business.Incluir(ficha);
                return Created("", ficha);
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
                
            }
        }
    }
}