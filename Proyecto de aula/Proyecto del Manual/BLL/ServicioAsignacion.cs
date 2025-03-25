using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioAsignacion
    {
        private readonly ServicioNotificacion servicioNotificacion;
        public ServicioAsignacion(ServicioNotificacion servicio_Notificacion)
        {
            servicioNotificacion = servicio_Notificacion;
        }

        public void AsignarEstudiante(Proyecto proyecto, Estudiante estudiante, Usuario usuario)
        {
            if (proyecto == null)
            {
                Console.WriteLine("Error: Hay un fallo en el proyecto.");
                return;
            }

            if (estudiante == null)
            {
                Console.WriteLine("Error: Hay un fallo con el estudiante.");
                return;
            }
            if (proyecto.AsignarEstudiante(estudiante))
            {
                string mensaje = $"El estudiante {estudiante.Nombre} ha sido asignado al proyecto '{proyecto.Titulo}'.";
                servicioNotificacion.NotificarUsuario(usuario, mensaje);
            }
        }
    }
}
