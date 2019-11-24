using LibraryServices.BLL;
using LibraryServices.DAL;
using LibraryServices.Entdades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using LibraryServices.UI.Registros;
using System.Security.Cryptography;
using System.Text;

namespace LibraryServices
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseData();
            Application.Run(new Logins());
        }
        public static string Hash(string input)
        {
            var hash = (new SHA1Managed()).ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Join("", hash.Select(b => b.ToString("x2")).ToArray());
        }
        static void DatabaseData()
        {
            Contexto db = new Contexto();

            RepositorioBase<Usuarios> genericaBLL = new RepositorioBase<Usuarios>(new Contexto());
            Usuarios usuario = genericaBLL.Buscar(1);
            EncryptKey encryptKey = new EncryptKey();
            if (usuario == null)
            {
                string password = encryptKey.cifrarTexto("Admin123");

                Usuarios usuario1 = new Usuarios(0, "Admin", "8294720158", "stevennunez829@gmail.com",password, DateTime.Now,"Administrador");
              

                db.Usuarios.Add(usuario1);
                db.SaveChanges();
            }

           
        }
    }
}
