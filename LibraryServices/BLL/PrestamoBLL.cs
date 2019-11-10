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
    public class PrestamoBLL
    {
        public static bool Guardar(Prestamo prestamo)
        {
            bool paso = false;
            Contexto db = new Contexto();


            try
            {
                
               
                if (db.Prestamo.Add(prestamo) != null)
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

        public static bool Modificar(Prestamo prestamo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {//Buscar las entidades que no estan para removerlas
                var Anterior =PrestamoBLL.Buscar(prestamo.PrestamoId);
                foreach (var item in Anterior.Detalle)
                {
                    if (!prestamo.Detalle.Exists(d => d.LibroId == item.LibroId))
                        db.Entry(item).State = EntityState.Deleted;
                }
                db.Entry(prestamo).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
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
                var eliminar = db.Prestamo.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
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

        public static Prestamo Buscar(int id)
        {

            Contexto db = new Contexto();
            Prestamo prestamo=new Prestamo();

            try
            {

                prestamo = db.Prestamo.Find(id);
                if (prestamo != null)
                    prestamo.Detalle.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return prestamo;

        }

        public static List<Prestamo> GetList(Expression<Func<Prestamo, bool>> asistencia)
        {
            List<Prestamo> Lista = new List<Prestamo>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Prestamo.Where(asistencia).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
