using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Entdades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaInsercion { get; set; }
        public string Nivel { get; set; }

        public Usuarios()
        {
        }

        public Usuarios(int usuarioId, string nombres, string celular, string email, string contraseña, DateTime fechaInsercion, string nivel)
        {
            UsuarioId = usuarioId;
            Nombres = nombres;
            Celular = celular;
            Email = email;
            Contraseña = contraseña;
            FechaInsercion = fechaInsercion;
            Nivel = nivel;
        }
    }
}
