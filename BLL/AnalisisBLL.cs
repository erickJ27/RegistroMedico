using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Consulta.Entidades;
using Sistema_Consulta.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Sistema_Consulta.BLL
{
    public class AnalisisBLL
    {
        public static bool Guardar(Analisis analisi)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                if (db.Analisi.Add(analisi) != null)
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
        public static bool Modificar(Analisis analisi)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var Anterior = db.Analisi.Find(analisi.AnalisisId);
                foreach (var item in Anterior.Resultado)
                {
                    if (!analisi.Resultado.Exists(d => d.Id == item.Id))
                        db.Entry(item).State = EntityState.Deleted;
                }
                db.Entry(analisi).State = EntityState.Modified;
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
            Contexto contexto = new Contexto();
            try
            {
                Analisis analisi = contexto.Analisi.Find(id);

                contexto.Analisi.Remove(analisi);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static Analisis Buscar(int id)
        {
            Contexto db = new Contexto();
            Analisis analisi = new Analisis();
            try
            {
                analisi = db.Analisi.Find(id);

                analisi.Resultado.Count();
            }
            catch
            {
                throw;

            }
            finally
            {
                db.Dispose();
            }
            return analisi;
        }
        public static List<Analisis> GetList(Expression<Func<Analisis, bool>> analisi)
        {
            List<Analisis> Lista = new List<Analisis>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Analisi.Where(analisi).ToList();
            }
            catch
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
