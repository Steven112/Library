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
                {
                    foreach (var item in prestamo.Detalle)
                    {
                        db.Libro.Find(item.LibroId).Disponibilidad = false;
                    }
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

        public static bool Modificar(Prestamo prestamo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var Anterior = PrestamoBLL.Buscar(prestamo.PrestamoId);
               foreach (var item in prestamo.Detalle)
               {
                   if (!prestamo.Detalle.Exists(d => d.DetalleId== item.DetalleId))
                    db.Entry(item).State = EntityState.Deleted;
                    db.Libro.Find(item.LibroId).Disponibilidad = false;

                }
                foreach (var item in prestamo.Detalle)
                {
                    if(item.DetalleId == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry(item).State = EntityState.Modified;
                    }

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
                Prestamo prestamo = db.Prestamo.Find(id);

                foreach (var item in prestamo.Detalle)
                {
                    var eliminar = db.Prestamo.Find(id);

                    db.Libro.Find(item.LibroId).Disponibilidad = true;
                  

                }
                db.Prestamo.Remove(prestamo);
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
                //db.Dispose();
            }
            return Lista;
        }
    }
}
