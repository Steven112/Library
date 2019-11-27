using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryServices.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryServices.Entdades;
using LibraryServices.Entidades;

namespace LibraryServices.BLL.Tests
{
    [TestClass()]
    public class DevolucionesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            DevolucionDetalles devolucionDetalles = new DevolucionDetalles(1, 1, "Moni", DateTime.Now);

            List<DevolucionDetalles> list = new List<DevolucionDetalles>();
            list.Add(devolucionDetalles);
            Devoluciones devoluciones= new Devoluciones(1,true,1,1,null,1,null, list,DateTime.Now, DateTime.Now);
            bool realizado = DevolucionesBLL.Guardar(devoluciones);
            Assert.AreEqual(true, realizado);


        }

        [TestMethod()]
        public void ModificarTest()
        {
            DevolucionDetalles devolucionDetalles = new DevolucionDetalles(1, 1, "Monki", DateTime.Now);

            List<DevolucionDetalles> list = new List<DevolucionDetalles>();
            list.Add(devolucionDetalles);
            Devoluciones devoluciones = new Devoluciones(1, true, 1, 1, null, 1, null, list, DateTime.Now, DateTime.Now);
            bool realizado = DevolucionesBLL.Guardar(devoluciones);
            Assert.AreEqual(true, realizado);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool realizado = DevolucionesBLL.Eliminar(1);
            Assert.AreEqual(realizado, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var encontrado = DevolucionesBLL.Buscar(2);
            Assert.IsNotNull(encontrado);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Devoluciones> lista = new List<Devoluciones>();
            lista = DevolucionesBLL.GetList(l => true);
            Assert.IsNotNull(lista);
        }
    }
}