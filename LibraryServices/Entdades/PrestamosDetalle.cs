using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Entdades
{
    public class PrestamosDetalle
    {
        [Key]


        public int LibroId { get; set; }
        public string NombreLibro { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public PrestamosDetalle(int libroId, string nombreLibro, DateTime fechaDevolucion)
        {
            LibroId = libroId;
            NombreLibro = nombreLibro;
            FechaDevolucion = fechaDevolucion;
        }

        public PrestamosDetalle()
        {
        }
    }
}
