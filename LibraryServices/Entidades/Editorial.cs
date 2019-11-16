using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Entdades
{
    public class Editorial
    {
        [Key]
        public int EditorialId { get; set; }
        public string Nombre { get; set; }
        public string Dirrecion { get; set; }

        public Editorial()
        {
        }

        public Editorial(int editorialId, string nombre, string dirrecion)
        {
            EditorialId = editorialId;
            Nombre = nombre;
            Dirrecion = dirrecion;
        }
    }
}
