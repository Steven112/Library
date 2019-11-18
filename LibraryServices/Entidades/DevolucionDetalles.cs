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
        public int DetalleId { get; set; }
        public int LibroId { get; set; }
        public string TituloLibro { get; set; }
        public int EstudianteId { get; set; }
        public bool Disponibilidad { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaDeDevueltaLibro { get; set; }

        public DevolucionDetalles(int libroId, string tituloLibro, int estudianteId, bool disponibilidad, DateTime fechaDevolucion, DateTime fechaDeDevueltaLibro)
        {
            LibroId = libroId;
            TituloLibro = tituloLibro;
            EstudianteId = estudianteId;
            Disponibilidad = disponibilidad;
            FechaDevolucion = fechaDevolucion;
            FechaDeDevueltaLibro = fechaDeDevueltaLibro;
        }

        public DevolucionDetalles()
        {
        }
    }
}
