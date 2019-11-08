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
        public int EditarialId { get; set; }
        public string Nombre { get; set; }
        public string Dirrecion { get; set; }

        public Editorial()
        {
        }

        public Editorial(int editarialId, string nombre, string dirrecion)
        {
            EditarialId = editarialId;
            Nombre = nombre;
            Dirrecion = dirrecion;
        }
    }
}
