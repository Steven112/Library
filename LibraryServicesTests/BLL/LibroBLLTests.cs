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
            libro.ISBN = "78nj";
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
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}