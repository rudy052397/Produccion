using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Conexion
{
    public class Informes
    {
        public static List<dynamic> BitacoraEquipo()
        {
            using (PRODUCCIONEntities db = new PRODUCCIONEntities())
            {
                var lst = from d in db.Equipos
                          join e in
                          (from f in db.Bitacora
                           group f by f.ID_EQUIPO into grp
                           select new { eq = grp.Key, cant = grp.Count() }
                          )
                          on d.ID equals e.eq into tfinal
                          from de in tfinal.DefaultIfEmpty()
                          orderby de.cant ascending
                          select new
                          {
                              EQUIPO = d.NOMBRE,
                              CANTIDAD = de.cant == null ? 0 :de.cant
                          };
                return lst.ToList<dynamic>();
            }
        }
        public static List<info> BitacoraZona()
        {
            using (PRODUCCIONEntities db = new PRODUCCIONEntities())
            { 
                List<info> lst = new List<info>();
                 lst = (from d in 
                              (from m in db.Equipos
                               group m by m.ZONA into __grp
                               select new { ZONA = __grp.Key }
                              
                              )
                          join e in
                            (
                              from x in db.Bitacora
                              join y in db.Equipos
                              on x.ID_EQUIPO equals y.ID into _tfinal
                              from xy in _tfinal.DefaultIfEmpty()
                              group xy by xy.ZONA into _grp
                              select new { ZONA = _grp.Key, CANTIDAD = _grp.Count() }
                            )
                          on d.ZONA equals e.ZONA into tfinal
                          from de in tfinal.DefaultIfEmpty()
                          select new info
                          {
                              ZONA = d.ZONA,
                              CANTIDAD = de.CANTIDAD == null ? 0 : de.CANTIDAD
                          }).ToList();
                return lst;
                
            }
        }
    }
    public class info
    {
        public string ZONA { get; set; }
        public int CANTIDAD { get; set; }
    }
}
