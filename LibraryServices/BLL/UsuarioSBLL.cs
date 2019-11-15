using LibraryServices.DAL;
using LibraryServices.Entdades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                if (db.Usuarios.Add(usuario) != null)
                {
                    paso=db.SaveChanges()>0;
                    
                }
                 
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            
            return paso;
        }


        public static bool Modificar(Usuarios usuario)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                db.Entry(usuario).State = EntityState.Modified;
                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;

        }


        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                Usuarios usuario = db.Usuarios.Find(id);

                var eliminar = db.Usuarios.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
            
        }


        public static Usuarios Buscar(int id)
        {
            Contexto db = new Contexto();
            Usuarios usuario = new Usuarios();
            try
            {
                usuario = db.Usuarios.Find(id);
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return usuario;
        }


        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> expression)
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            Contexto contexto = new Contexto();

            try
            {
                usuarios = contexto.Usuarios.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return usuarios;
        }
    }
}
