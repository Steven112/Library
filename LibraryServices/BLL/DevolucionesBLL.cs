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
    public class DevolucionesBLL
    {
        public static bool Guardar(Devoluciones devoluciones)
        {
            Prestamo prestamo = new Prestamo();
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Devolucion.Add(devoluciones) != null)
                {

                    foreach (var item in devoluciones.DetalleDev)
                    {
                        db.Libro.Find(item.LibroId).Disponibilidad = true;
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


        public static bool Modificar(Devoluciones devoluciones)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                var Anterior = DevolucionesBLL.Buscar(devoluciones.DevolucionId);
                foreach (var item in Anterior.DetalleDev)
                {
                    if (!devoluciones.DetalleDev.Exists(d => d.DevolucionDetId == item.DevolucionDetId))
                        db.Entry(item).State = EntityState.Deleted;
                        db.Libro.Find(item.LibroId).Disponibilidad = true;
                }
                foreach (var item in devoluciones.DetalleDev)
                {
                    if (item.DevolucionDetId == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry(item).State = EntityState.Modified;
                    }

                }
                db.Entry(devoluciones).State = EntityState.Modified;
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
                Devoluciones devoluciones = db.Devolucion.Find(id);

                foreach (var item in devoluciones.DetalleDev)
                {
                    var eliminar = db.Devolucion.Find(id);

                    db.Libro.Find(item.LibroId).Disponibilidad = true;


                }
                db.Devolucion.Remove(devoluciones);
                paso = (db.SaveChanges() > 0); 
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static Devoluciones Buscar(int id)
        {
            Contexto db = new Contexto();
            Devoluciones devoluciones = new Devoluciones();
            try
            {
                devoluciones = db.Devolucion.Find(id);
                if (devoluciones != null)
                    devoluciones.DetalleDev.Count();
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return devoluciones;
        }


        public static List<Devoluciones> GetList(Expression<Func<Devoluciones, bool>> expression)
        {
            List<Devoluciones> libro = new List<Devoluciones>();
            Contexto db = new Contexto();

            try
            {
                libro = db.Devolucion.Where(expression).ToList();
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
