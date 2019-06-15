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
    public class TipoAnalisisBLL
    {
        public static bool Guardar(TipoAnalisis tipoAnalisi)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                if (db.TipoAnalisi.Add(tipoAnalisi) != null)
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
        public static bool Modificar(TipoAnalisis tipoAnalisis)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(tipoAnalisis).State = EntityState.Modified;
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
                TipoAnalisis ubicacion = contexto.TipoAnalisi.Find(id);

                contexto.TipoAnalisi.Remove(ubicacion);

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
        public static TipoAnalisis Buscar(int id)
        {
            Contexto db = new Contexto();
            TipoAnalisis tipoAnalisi = new TipoAnalisis();
            try
            {
                tipoAnalisi = db.TipoAnalisi.Find(id);
            }
            catch
            {
                throw;

            }
            finally
            {
                db.Dispose();
            }
            return tipoAnalisi;
        }
        public static List<TipoAnalisis> GetList(Expression<Func<TipoAnalisis, bool>> tipoAnalisi)
        {
            List<TipoAnalisis> Lista = new List<TipoAnalisis>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.TipoAnalisi.Where(tipoAnalisi).ToList();
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
