using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Entdades
{
    public class Libro
    {
        [Key]
        public int LibroId { get; set; }
        public string NombreLibro { get; set; }
        public string ISBN { get; set; }
        public int CategoriaId { get; set; }
        public string Introduccion { get; set; }
        public int EditorialId { get; set; }
        [ForeignKey("EditorialId")]
        public Editorial editorial { get; set; }
        public DateTime FechaImpresion { get; set; }
        public bool Disponibilidad { get; set; }

        public Libro()
        {
            LibroId = 0;
            NombreLibro = string.Empty;
            ISBN = string.Empty;
            CategoriaId = 0;
            Introduccion = string.Empty;
            EditorialId = 0;
            FechaImpresion = DateTime.Now;
            Disponibilidad = true;
        }

       
    }
}
