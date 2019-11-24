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
    public class EstudianteBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Estudiante estudiante = new Estudiante(5, "Manuel", "Perez", "20170605", "825947852", "ggt/25", "stn6♦gmail.com", DateTime.Now, 1, null);
            bool paso= EstudianteBLL.Guardar(estudiante);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
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