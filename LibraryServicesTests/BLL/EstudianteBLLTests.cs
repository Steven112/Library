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
            Estudiante estudiante = new Estudiante(8, "Manuel", "Perez", "20170605", "825947852", "ggt/25", "stn6♦gmail.com", DateTime.Now, 1, null);
            bool paso= EstudianteBLL.Guardar(estudiante);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Estudiante estudiante = new Estudiante(8, "Manuele", "Perez", "20170615", "825947852", "ggt/25", "stn6♦gmail.com", DateTime.Now, 1, null);
            bool paso = EstudianteBLL.Guardar(estudiante);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var encontrado = EstudianteBLL.Buscar(5);
            Assert.IsNotNull(encontrado);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool realizado = EstudianteBLL.Eliminar(5);
            Assert.AreEqual(realizado, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Estudiante> lista = new List<Estudiante>();
            lista = EstudianteBLL.GetList(l => true);
            Assert.IsNotNull(lista);
        }
    }
}