using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Entdades
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Categoria()
        {
        }

        public Categoria(int categoriaId, string nombre, string descripcion)
        {
            CategoriaId = categoriaId;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
