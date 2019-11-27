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
            PrestamosDetalle pagosDetalle = new PrestamosDetalle(1,1,"Menu", DateTime.Now);
            List<PrestamosDetalle> list = new List<PrestamosDetalle>();
            list.Add(pagosDetalle);
            Prestamo prestamo = new Prestamo(1,1,null,1, DateTime.Now, DateTime.Now,list);
            bool realizado = PrestamoBLL.Guardar(prestamo);
            Assert.AreEqual(true, realizado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            PrestamosDetalle pagosDetalle = new PrestamosDetalle(1, 1, "Menpu", DateTime.Now);
            PrestamosDetalle pagosDetalle1 = new PrestamosDetalle(1, 1, "Menu", DateTime.Now);
            List<PrestamosDetalle> list = new List<PrestamosDetalle>();
            list.Add(pagosDetalle);
            list.Add(pagosDetalle1);
            Prestamo prestamo = new Prestamo(7, 1, null, 1, DateTime.Now, DateTime.Now, list);
            bool realizado = PrestamoBLL.Guardar(prestamo);
            Assert.AreEqual(true, realizado);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool realizado = PrestamoBLL.Eliminar(1);
            Assert.AreEqual(realizado, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var encontrado = PrestamoBLL.Buscar(1);
            Assert.IsNotNull(encontrado);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Prestamo> lista = new List<Prestamo>();
            lista = PrestamoBLL.GetList(l => true);
            Assert.IsNotNull(lista);
        }
    }
}