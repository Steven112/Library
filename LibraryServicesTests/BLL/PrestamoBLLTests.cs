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
    public class PrestamoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            PrestamosDetalle pagosDetalle = new PrestamosDetalle(2,1,"Menu", DateTime.Now);
            List<PrestamosDetalle> list = new List<PrestamosDetalle>();
            list.Add(pagosDetalle);
            Prestamo prestamo = new Prestamo(2,1,null,1, DateTime.Now, DateTime.Now,list);
            bool realizado = PrestamoBLL.Guardar(prestamo);
            Assert.AreEqual(true, realizado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            PrestamosDetalle pagosDetalle = new PrestamosDetalle(2, 1, "Menu", DateTime.Now);
            PrestamosDetalle pagosDetalle1 = new PrestamosDetalle(3, 1, "Menu", DateTime.Now);
            List<PrestamosDetalle> list = new List<PrestamosDetalle>();
            list.Add(pagosDetalle);
            list.Add(pagosDetalle1);
            Prestamo prestamo = new Prestamo(2, 1, null, 1, DateTime.Now, DateTime.Now, list);
            bool realizado = PrestamoBLL.Guardar(prestamo);
            Assert.AreEqual(true, realizado);
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