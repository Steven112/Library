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
        public int DevolucionDetId { get; set; }
        public int PrestamoId { get; set; }
        public int LibroId { get; set; }
        public string NombreLibro { get; set; }
        public DateTime FechaDevueltaLibro { get; set; }
        public DevolucionDetalles()
        {
        }

        public DevolucionDetalles(int prestamoId, int libroId, string nombreLibro, DateTime fechaDevueltaLibro)
        {
            PrestamoId = prestamoId;
            LibroId = libroId;
            NombreLibro = nombreLibro;
            FechaDevueltaLibro = fechaDevueltaLibro;
        }
    }
}
