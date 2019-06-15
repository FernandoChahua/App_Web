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
    [Route("actividad")]
    [ApiController]
    public class ActividadController : ControllerBase
    {
        private IActividadService actividadService;
        public ActividadController(IActividadService actividadService)
        {
            this.actividadService = actividadService;
        }
        [HttpGet]
        public IEnumerable<Actividad> GetActividad()
        {
            return actividadService.ListAll();
        }


        [HttpGet("{id}")]
        public IActionResult GetActividad([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var currentActividad = actividadService.FindById(new Actividad { IdActividad = id });

            if (currentActividad == null)
            {
                return NotFound();
            }

            return Ok(currentActividad);

        }

        [HttpPost]
        public IActionResult PostActividad([FromBody] Actividad actividad)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            actividadService.Save(actividad);

            return CreatedAtAction("GetActividad", new { id = actividad.IdActividad }, actividad);
        }


        [HttpPut("{id}")]
        public IActionResult PutActividad([FromRoute] int id, [FromBody] Actividad actividad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (actividad.IdActividad != id)
            {
                return NotFound();
            }

            actividadService.Update(actividad);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteActividad([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var currentActividad = actividadService.FindById(new Actividad { IdActividad = id });

            if (currentActividad == null)
            {
                return NotFound();
            }

            actividadService.Delete(currentActividad);

            return Ok(currentActividad);
        }
    }
}