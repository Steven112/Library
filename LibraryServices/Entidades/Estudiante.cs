using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Entdades
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos{ get; set; }
        public string Matricula { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public DateTime FechaInsercion { get; set; }
        public int UsuarioId { get; set; }
        

        public Estudiante()
        {
        }

        public Estudiante(int estudianteId, string nombres, string apellidos, string matricula, string celular, string direccion, string email, DateTime fechaInsercion, int usuarioId)
        {
            EstudianteId = estudianteId;
            Nombres = nombres;
            Apellidos = apellidos;
            Matricula = matricula;
            Celular = celular;
            Direccion = direccion;
            Email = email;
            FechaInsercion = fechaInsercion;
            UsuarioId = usuarioId;
        }
    }
}
