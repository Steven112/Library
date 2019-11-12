using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int LibroId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string Matricula { get; set; }
        public virtual List<PrestamosDetalle> Detalle { get; set; }

        public Prestamo(int prestamoId, int estudianteId, int libroId, DateTime fechaPrestamo, DateTime fechaDevolucion, string matricula, List<PrestamosDetalle> detalle)
        {
            PrestamoId = prestamoId;
            EstudianteId = estudianteId;
            LibroId = libroId;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            Matricula = matricula;
            Detalle = detalle;
        }

        public Prestamo()
        {
        }
       
    }
}
