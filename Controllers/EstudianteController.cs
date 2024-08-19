using Microsoft.AspNetCore.Mvc;
using Practica1.Models;

namespace Practica1.Controllers
{
    public class EstudianteController : Controller
    {
        public IActionResult Index()
        {
            var estudiante = new Estudiante
            {
                Nombre = "Victor Alejandro",
                Apellido = "Vargas Fuster",
                CodigosAsignaturas = new List<string>
                {
                    "INF-422-02",
                    "INF-556-01",
                    "INF-576-01",
                    "MAT-132-01"
                },
                Hobbies = new List<string>
                {
                    "Jugar videojuegos",
                    "Jugar basketball",
                    "Leer"
                }
            };

            return View(estudiante);
        }
    }
}
