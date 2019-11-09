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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Matricula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaInsercion { get; set; }

        public Estudiante()
        {
        }

        public Estudiante(int estudianteId, string nombre, string apellido, string matricula, string telefono, string direccion, DateTime fechaInsercion)
        {
            EstudianteId = estudianteId;
            Nombre = nombre;
            Apellido = apellido;
            Matricula = matricula;
            Telefono = telefono;
            Direccion = direccion;
            FechaInsercion = fechaInsercion;
        }
    }
}
