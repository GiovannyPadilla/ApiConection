using ApiConection.Interfaces;
using ApiConection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiConection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        IEstudianteRepository _estudianteRepository;

        public EstudiantesController()
        {
            _estudianteRepository = new EstudianteRepository();
        }
        [HttpGet]
        public IActionResult DevulveListdoEstudiantes()
        {
           var estudiantes = _estudianteRepository.DevuelveListadoEstudiante();
            return Ok(estudiantes);
        }

        [Route("InfoEstudiante/{bannerID}")]
        [HttpGet]
        public IActionResult GetInformacionEstudiante(string bannerId)
        {
            
            try 
            {
                var infoEstudiante = _estudianteRepository.DevuelveInformacionEstudiante(bannerId);
                return Ok(infoEstudiante);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
