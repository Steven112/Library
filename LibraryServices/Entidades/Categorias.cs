using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Entdades
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioId { get; set; }

        public Categoria()
        {
        }

        public Categoria(int categoriaId, string descripcion, int usuarioId)
        {
            CategoriaId = categoriaId;
            Descripcion = descripcion;
            UsuarioId = usuarioId;
        }
    }
}
