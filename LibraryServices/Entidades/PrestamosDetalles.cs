using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Entdades
{
    public class PrestamosDetalle
    {
        [Key]
        public int PrestamoDetailsId { get; set; }
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
