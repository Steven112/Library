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
    public class EstudianteBLL
    {
        public static bool Guardar(Estudiante estudiante)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                if (db.Estudiante.Add(estudiante) != null)
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

        public static bool Modificar(Estudiante estudiante)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                db.Entry(estudiante).State = EntityState.Modified;
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
        public static Estudiante Buscar(int id)
        {
            Contexto db = new Contexto();
            Estudiante estudiante = new Estudiante();
            try
            {
                estudiante = db.Estudiante.Find(id);
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return estudiante;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                Estudiante estudiante = db.Estudiante.Find(id);

                db.Estudiante.Remove(estudiante);

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
        public static List<Estudiante> GetList(Expression<Func<Estudiante, bool>> expression)
        {
            List<Estudiante> lista = new List<Estudiante>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Estudiante.Where(expression).ToList();
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;

            
        }


    }
}
