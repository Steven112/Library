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
        public bool Disponible { get; set; }
        public int PrestamoId { get; set; }
        public int EstudianteId { get; set; }
        [ForeignKey("EstudianteId")]
        public Estudiante Estudiante { get; set; }
        public int LibroId { get; set; }
        [ForeignKey("LibroId")]
        public Libro libro { get; set; }
        public virtual List<DevolucionDetalles> DetalleDev { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaDevueltaLibro { get; set; }
        public int UsuarioId { get; set; }

        public Devoluciones(int devolucionId, bool disponible, int prestamoId, int estudianteId, Estudiante estudiante, int libroId, Libro libro, List<DevolucionDetalles> detalleDev, DateTime fechaDevolucion, DateTime fechaDevueltaLibro)
        {
            DevolucionId = devolucionId;
            Disponible = disponible;
            PrestamoId = prestamoId;
            EstudianteId = estudianteId;
            Estudiante = estudiante;
            LibroId = libroId;
            this.libro = libro;
            DetalleDev = detalleDev;
            FechaDevolucion = fechaDevolucion;
            FechaDevueltaLibro = fechaDevueltaLibro;
        }

        public Devoluciones()
        {
        }
    }
}
