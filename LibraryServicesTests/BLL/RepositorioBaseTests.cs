using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryServices.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryServices.Entdades;
using LibraryServices.DAL;

namespace LibraryServices.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
       

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            RepositorioBase<Categoria> Ct = new RepositorioBase<Categoria>(new Contexto());
            Categoria categoria = new Categoria();
            categoria.CategoriaId = 4;
            categoria.Descripcion = "hu";
            paso = Ct.Guardar(categoria);
            Assert.AreEqual(paso, true);

            bool paso1;
            RepositorioBase<Editorial> Ed = new RepositorioBase<Editorial>(new Contexto());
            Editorial editorial = new Editorial();
            editorial.EditorialId=4;
            editorial.Dirrecion = "Nada";
            editorial.Nombre = "Nu";
            paso1 = Ed.Guardar(editorial);
            Assert.AreEqual(paso1, true);

        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            RepositorioBase<Categoria> Ct = new RepositorioBase<Categoria>(new Contexto());
            Categoria categoria = new Categoria();
            categoria.CategoriaId = 1;
            categoria.Descripcion = "hu1";
            paso = Ct.Modificar(categoria);
            Assert.AreEqual(paso, true);

            bool paso1;
            RepositorioBase<Editorial> Ed = new RepositorioBase<Editorial>(new Contexto());
            Editorial editorial = new Editorial();
            editorial.EditorialId = 1;
            editorial.Dirrecion = "Nada";
            editorial.Nombre = "Nu1";
            paso1 = Ed.Modificar(editorial);
            Assert.AreEqual(paso1, true);
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