using EjercicioApi.Models;
using EjercicioApi.Repository;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace EjercicioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        [HttpGet]
        [Route("listado")]
        public List<Estudiante> DevuelveListadoEstudiantes()
        {
            EstudianteRepository repo = new EstudianteRepository();
            var listado = repo.DevuelveListadoEstudiantes();
            return listado;
        }

        [HttpGet]
        [Route("InformacionEstudiante/{id}")]
        public ActionResult<Estudiante> DevuelveInformacionEstudiante(int id)
        {
            try
            {
                EstudianteRepository repo = new EstudianteRepository();
                var listado = repo.DevuelveListadoEstudiantes();
                if (listado.Any(x => x.Id == id))
                {
                    var estudiante = listado.Find(x => x.Id == id);
                    return Ok(estudiante);
                }
                return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult GuardaEstudiante([FromBody] Estudiante estudiante)
        {
            try
            {
                // Aquí iría la lógica para guardar el estudiante en la base de datos o en la lista
                // Por ejemplo: repo.GuardaEstudiante(estudiante);

                // Devuelve una respuesta HTTP 200 OK si todo sale bien
                return Ok("Estudiante guardado exitosamente.");
            }
            catch (Exception e)
            {
                // Devuelve un 400 BadRequest si ocurre algún error
                return BadRequest(e.Message);
            }
        }
    }
}
