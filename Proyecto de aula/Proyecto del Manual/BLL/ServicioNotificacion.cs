using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioNotificacion
    {
        public void NotificarUsuario(Usuario usuario, string mensaje)
        {
            Console.WriteLine($"Enviando notificación a {usuario.Nombre} ({usuario.Correo}): {mensaje}");
        }
    }
}
