using LibraryServices.Entdades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Entidades
{
    public class DevolucionDetalles
    {
        [Key]
        public int DevolucionId { get; set; }
        public int PrestamoId { get; set; }
        public int EstudianteId { get; set; }
        [ForeignKey("EstudianteId")]
        public virtual Estudiante Estudiante { get; set; }
        public int LibroId { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaDevueltaLibro { get; set; }

        public DevolucionDetalles(int prestamoId, int libroId, DateTime fechaDevolucion, DateTime fechaDevueltaLibro)
        {
            PrestamoId = prestamoId;
            LibroId = libroId;
            FechaDevolucion = fechaDevolucion;
            FechaDevueltaLibro = fechaDevueltaLibro;
        }

        public DevolucionDetalles()
        {
        }
    }
}
