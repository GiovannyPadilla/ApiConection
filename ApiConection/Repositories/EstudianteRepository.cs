using ApiConection.Interfaces;
using ApiConection.Models;

namespace ApiConection.Repositories
{
    public class EstudianteRepository : IEstudianteRepository
    {
        public Estudiante DevuelveInformacionEstudiante(string bannerId)
        {
            var estudiantes = DevuelveListadoEstudiante();
            return estudiantes.First(item => item.bannerId == bannerId);
        }

        public IEnumerable<Estudiante> DevuelveListadoEstudiante()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            Estudiante estudiante1 = new Estudiante
            {
                bannerId = "123456",
                nombre = "Juan Perez",
                edad = 20,
                tieneBeca = false
            };
            estudiantes.Add(estudiante1);

            Estudiante estudiante2 = new Estudiante
            {
                bannerId = "654321",
                nombre = "Maria Lopez",
                edad = 22,
                tieneBeca = true
            };
            estudiantes.Add(estudiante2);
            return estudiantes;
        }
    }
}
