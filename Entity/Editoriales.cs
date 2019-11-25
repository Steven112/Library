using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int UsuarioId { get; set; }

        public Editorial()
        {
        }

        public Editorial(int editorialId, string nombre, string dirrecion, int usuarioId)
        {
            EditorialId = editorialId;
            Nombre = nombre;
            Dirrecion = dirrecion;
            UsuarioId = usuarioId;
        }
    }
}
