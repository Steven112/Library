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
    public class LibroBLL
    {
        public static bool Guardar(Libro libro)
        {
            bool paso = false;

            Contexto db= new Contexto();
            try
            {
                if (db.Libro.Add(libro) != null)
                {
                    db.SaveChanges();
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


        public static bool Modificar(Libro libro)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                db.Entry(libro).State = EntityState.Modified;
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
                Libro libro = db.Libro.Find(id);

                db.Libro.Remove(libro);

                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }
               
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static Libro Buscar(int id)
        {
            Contexto db = new Contexto();
            Libro libros = new Libro();
            try
            {
                libros = db.Libro.Find(id);
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return libros;
        }


        public static List<Libro> GetList(Expression<Func<Libro, bool>> expression)
        {
            List<Libro> libro = new List<Libro>();
            Contexto db = new Contexto();

            try
            {
                libro = db.Libro.Where(expression).ToList();
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return libro;
        }

    }
}
