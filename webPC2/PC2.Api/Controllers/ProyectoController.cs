using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PC2.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PC2.Repository.Context;
using PC2.Service;


namespace PC2.Api.Controllers
{
    [Route("api/proyecto")]
    [ApiController]
    public class ProyectoController : ControllerBase
    {
        private IProyectoService proyectoService;
        public ProyectoController(IProyectoService proyectoService)
        {
            this.proyectoService = proyectoService;
        }
        [HttpGet]
        public IEnumerable<Proyecto> GetProyecto()
        {
            return proyectoService.ListAll();
        }


        [HttpGet("{id}")]
        public IActionResult GetProyecto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var currentProyecto = proyectoService.FindById(new Proyecto { IdProyecto = id });

            if (currentProyecto == null)
            {
                return NotFound();
            }

            return Ok(currentProyecto);

        }

        [HttpPost]
        public IActionResult PostProyecto([FromBody] Proyecto proyecto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            proyectoService.Save(proyecto);

            return CreatedAtAction("GetProyecto", new { id = proyecto.IdProyecto }, proyecto);
        }


        [HttpPut("{id}")]
        public IActionResult PutProyecto([FromRoute] int id, [FromBody] Proyecto proyecto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (proyecto.IdProyecto != id)
            {
                return NotFound();
            }

            proyectoService.Update(proyecto);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProyecto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var currentProyecto = proyectoService.FindById(new Proyecto { IdProyecto = id });

            if (currentProyecto == null)
            {
                return NotFound();
            }

            proyectoService.Delete(currentProyecto);

            return Ok(currentProyecto);
        }
    }
}