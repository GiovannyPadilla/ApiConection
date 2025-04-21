using ApiConection.Models;

namespace ApiConection.Interfaces
{
    public interface IEstudianteRepository
    {
        IEnumerable<Estudiante> DevuelveListadoEstudiante();
        Estudiante DevuelveInformacionEstudiante(string bannerId);
    }
}
