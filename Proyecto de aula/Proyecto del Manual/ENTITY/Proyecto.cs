using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Proyecto
    {
        public int IdProyecto { get; set; }
        public int? IdEstudianteAsignado { get; private set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public void ActualizarEstado(string nuevoEstado)
        {
            Estado = nuevoEstado;
            Console.WriteLine($"Estado del proyecto '{Titulo}' actualizado a: {Estado}");
        }
        public bool AsignarEstudiante(Estudiante estudiante)
        {
            if (IdEstudianteAsignado != null)
            {
                Console.WriteLine($"Error: El proyecto '{Titulo}' ya tiene un estudiante asignado.");
                return false;
            }

            IdEstudianteAsignado = estudiante.Id;
            Console.WriteLine($"Estudiante {estudiante.Nombre} asignado al proyecto '{Titulo}'.");
            return true;
        }
    }
}
