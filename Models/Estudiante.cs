namespace Practica1.Models
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<string> CodigosAsignaturas { get; set; }
        public List<string> Hobbies { get; set; }
    }
}
