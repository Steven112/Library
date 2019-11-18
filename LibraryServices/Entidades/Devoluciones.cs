using LibraryServices.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int LibroId { get; set; }
        public bool Disponible { get; set; }
        public virtual List<DevolucionDetalle> DetalleDev { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaDevueltaLibro { get; set; }

        public Devoluciones(int devolucionId, int estudianteId, int libroId, bool disponible, List<DevolucionDetalle> detalleDev, DateTime fechaDevolucion, DateTime fechaDevueltaLibro)
        {
            DevolucionId = devolucionId;
            EstudianteId = estudianteId;
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
