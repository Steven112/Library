using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Entdades
{
    public class Libro
    {
        [Key]
        public int LibroID { get; set; }
        public string NombreLibro { get; set; }
        public string ISBN { get; set; }
        public int CategoriaID { get; set; }
        public string Introduccion { get; set; }
        public int EditorialID { get; set; }
        public DateTime FechaImpresion { get; set; }
        public bool Disponibilidad { get; set; }

        public Libro()
        {

        }

        public Libro(int libroID, string nombreLibro, string iSBN, int categoriaID, string introduccion, int editorialID, DateTime fechaImpresion, bool disponibilidad)
        {
            LibroID = libroID;
            NombreLibro = nombreLibro;
            ISBN = iSBN;
            CategoriaID = categoriaID;
            Introduccion = introduccion;
            EditorialID = editorialID;
            FechaImpresion = fechaImpresion;
            Disponibilidad = disponibilidad;
        }
    }
}
