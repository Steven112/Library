using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Entdades
{
    public class PrestamoDetalle
    {
        [Key]
        public int Id { get; set; }
        public int PrestamoId { get; set; }
        public int EstudianteId { get; set; }
        public int LibroId { get; set; }
        public string Matricula { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public PrestamoDetalle(int id, int prestamoId, int estudianteId, int libroId, string matricula, DateTime fechaDevolucion)
        {
            Id = id;
            PrestamoId = prestamoId;
            EstudianteId = estudianteId;
            LibroId = libroId;
            Matricula = matricula;
            FechaDevolucion = fechaDevolucion;
        }

        public PrestamoDetalle()
        {
        }
    }
}
