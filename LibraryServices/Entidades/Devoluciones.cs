using LibraryServices.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Entdades
{
    public class Devoluciones
    {
        [Key]
        public int DevolucionId { get; set; }     
        public int EstudianteId { get; set; }
        [ForeignKey("EstudianteId")]
        public Estudiante estudiante { get; set; }
        public int LibroId { get; set; }
        public bool Disponible { get; set; }
        public virtual List<DevolucionDetalles> DetalleDev { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaDevueltaLibro { get; set; }

        public Devoluciones(int devolucionId, int estudianteId, Estudiante estudiante, int libroId, bool disponible, List<DevolucionDetalles> detalleDev, DateTime fechaDevolucion, DateTime fechaDevueltaLibro)
        {
            DevolucionId = devolucionId;
            EstudianteId = estudianteId;
            this.estudiante = estudiante;
            LibroId = libroId;
            Disponible = disponible;
            DetalleDev = detalleDev;
            FechaDevolucion = fechaDevolucion;
            FechaDevueltaLibro = fechaDevueltaLibro;
        }

        public Devoluciones()
        {
        }
    }
}
