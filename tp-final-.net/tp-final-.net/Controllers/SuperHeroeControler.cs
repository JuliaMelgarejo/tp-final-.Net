using Microsoft.AspNetCore.Mvc;
using tp_final_.net.Models;

namespace tp_final_.net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperheroeController : ControllerBase
    {
        [HttpGet("Crear-SuperHeroe")]
        public ActionResult CrearSuperheroe(string nombre, string tipo)
        {
            ISuperHeroe _superheroe;
            try
            {
                _superheroe = SuperHeroeF.CrearSuperheroe(nombre, tipo);
            }
            catch (ArgumentException)
            {
                return BadRequest("Tipo de héroe no reconocido.");
            }
            return Ok(new
            {
                Nombre = _superheroe.Nombre,
                PoderEspecial = _superheroe.PoderEspecial,
                Fuerza = _superheroe.Fuerza,
                Salud = _superheroe.Salud
            });
        }

        [HttpGet("visitar-enfermeria")]
        public ActionResult VisitarEnfermeria(string tipo, int saludActual, int cantidadVisitas)
        {
            if (cantidadVisitas < 1 || cantidadVisitas > 5)
            {
                return BadRequest("La cantidad de visitas debe ser entre 1 y 5.");
            }
            if (saludActual < 0 || saludActual > 5)
            {
                return BadRequest("La salud debe estar entre 0 y 5.");
            }

            if (string.IsNullOrEmpty(tipo))
            {
                return BadRequest("El tipo de superhéroe es obligatorio.");
            }

            var enfermeria = Enfermeria.ObtenerInstancia();

            bool visitaExitosa = enfermeria.VisitarEnfermeria(ref saludActual, cantidadVisitas);

            if (visitaExitosa)
            {
                return Ok(new { Salud = saludActual });
            }
            else
            {
                return BadRequest("No se pueden realizar más visitas a la enfermería.");
            }
        }
    }
}
