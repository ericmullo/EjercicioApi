using EjercicioApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioApi.Repository
{
    public class EstudianteRepository
    {
        public List<Estudiante> DevuelveListadoEstudiantes()
        {
            List<Estudiante> listado = new List<Estudiante>();

            Estudiante estudiante1 = new Estudiante
            {
                Id = 1,
                Nombre = "Santiago",
                Edad = 20,
                TieneBeca = true
            };

            Estudiante estudiante2 = new Estudiante
            {
                Id = 2,
                Nombre = "Paula",
                Edad = 19,
                TieneBeca = false
            };

            listado.Add(estudiante1);
            listado.Add(estudiante2);

            return listado;
        }
       

    }
}
