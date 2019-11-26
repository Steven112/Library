using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryServices.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryServices.Entdades;

namespace LibraryServices.BLL.Tests
{
    [TestClass()]
    public class LibroBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Libro libro = new Libro();
            bool paso;
            libro.LibroId = 2;
            libro.NombreLibro = "Coco";
            libro.ISBN = "78nj";
            libro.CategoriaId = 1;
            libro.EditorialId = 1;
            libro.FechaImpresion = DateTime.Now;
            libro.Disponibilidad = true;
            paso = LibroBLL.Guardar(libro);
            Assert.AreEqual(paso, true);

            
        }

        [TestMethod()]
        public void ModificarTest()

        {
            Libro libro = new Libro();
            bool paso;
            libro.LibroId = 1;
            libro.NombreLibro = "Coco";
            libro.ISBN = "789neej";
            libro.CategoriaId = 1;
            libro.EditorialId = 1;
            libro.FechaImpresion = DateTime.Now;
            libro.Disponibilidad = true;
            paso = LibroBLL.Guardar(libro);
            Assert.AreEqual(paso, true);

            paso = LibroBLL.Modificar(libro);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool realizado = LibroBLL.Eliminar(8);
            Assert.AreEqual(realizado, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var encontrado = LibroBLL.Buscar(1);
            Assert.IsNotNull(encontrado);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Libro> lista = new List<Libro>();
            lista = LibroBLL.GetList(l => true);
            Assert.IsNotNull(lista);
        }
    }
}