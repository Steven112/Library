using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Entdades
{
    public class Prestamo
    {
        [Key]
        public int PrestamoId { get; set; }
        public int EstudianteId { get; set; }
        [ForeignKey("EstudianteId")]
        public Estudiante Estudiante { get; set; }
        public int LibroId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public virtual List<PrestamosDetalle> Detalle { get; set; }

        public Prestamo(int prestamoId, int estudianteId, Estudiante estudiante, int libroId, DateTime fechaPrestamo, DateTime fechaDevolucion, List<PrestamosDetalle> detalle)
        {
            PrestamoId = prestamoId;
            EstudianteId = estudianteId;
            Estudiante = estudiante;
            LibroId = libroId;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            Detalle = detalle;
        }

        public Prestamo()
        {
        }
       
    }
}
