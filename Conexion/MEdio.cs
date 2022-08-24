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
    public class MEdio
    {
        public static List<dynamic> inicio()
        {
            using (PRODUCCIONEntities db1 = new PRODUCCIONEntities())
            {

                var lst = from d1 in (from d in db1.Equipos
                                      join e in
                                      (
                                      from a in db1.Bitacora
                                      where a.ASUNTO == "Cambio de aceite"
                                      group a by a.ID_EQUIPO into grp
                                      select new { ID = grp.Key, FECHA = grp.Max(C => C.FECHA) }
                                      )
                                      on d.ID equals e.ID into final
                                      from de in final.DefaultIfEmpty()
                                      orderby de.FECHA.HasValue descending, de.FECHA
                                      select new
                                      {
                                          //ID_1 = de == null ? 0 : de.ID,
                                          ID = d.ID,
                                          CODIGO_INT = d.CODIGO_INT,
                                          CODIGO_ADM = d.CODIGO_ADM,
                                          ZONA = d.ZONA,
                                          NOMBRE = d.NOMBRE,
                                          FECHA = d.UNIDAD == 1 ? SqlFunctions.DateAdd("day", d.CANTIDAD, de.FECHA) : (d.UNIDAD == 2 ? SqlFunctions.DateAdd("month", d.CANTIDAD, de.FECHA) : (d.UNIDAD == 3 ? SqlFunctions.DateAdd("year", d.CANTIDAD, de.FECHA) : null))

                                      })
                          orderby d1.FECHA.HasValue descending, d1.FECHA
                          select d1;
                          
                return lst.ToList<dynamic>();
            }
        }
        public static List<dynamic> Buscar(int c,string codigo, string zona)
        {
            using (PRODUCCIONEntities db1 = new PRODUCCIONEntities())
            {
                if (c == 0)
                {
                    return inicio();
                }
                else if (c == 1)
                {
                    var lst = from d1 in (from d in db1.Equipos
                                          join e in
                                          (
                                          from a in db1.Bitacora
                                          where a.ASUNTO == "Cambio de aceite"
                                          group a by a.ID_EQUIPO into grp
                                          select new { ID = grp.Key, FECHA = grp.Max(C => C.FECHA) }
                                          )
                                          on d.ID equals e.ID into final
                                          from de in final.DefaultIfEmpty()
                                          where d.ZONA == zona
                                          orderby de.FECHA.HasValue descending, de.FECHA
                                          select new
                                          {
                                              //ID_1 = de == null ? 0 : de.ID,
                                              ID = d.ID,
                                              CODIGO_INT = d.CODIGO_INT,
                                              CODIGO_ADM = d.CODIGO_ADM,
                                              ZONA = d.ZONA,
                                              NOMBRE = d.NOMBRE,
                                              FECHA = d.UNIDAD == 1 ? SqlFunctions.DateAdd("day", d.CANTIDAD, de.FECHA) : (d.UNIDAD == 2 ? SqlFunctions.DateAdd("month", d.CANTIDAD, de.FECHA) : (d.UNIDAD == 3 ? SqlFunctions.DateAdd("year", d.CANTIDAD, de.FECHA) : null))

                                          })

                              orderby d1.FECHA.HasValue descending, d1.FECHA
                              select d1;
                    return lst.ToList<dynamic>();
                }
                else if(c == 2)
                {
                    var lst = from d in db1.Equipos
                              join e in
                              (
                              from a in db1.Bitacora
                              where a.ASUNTO == "Cambio de aceite"
                              group a by a.ID_EQUIPO into grp
                              select new { ID = grp.Key, FECHA = grp.Max(C => C.FECHA) }
                              )
                              on d.ID equals e.ID into final
                              from de in final.DefaultIfEmpty()
                              where d.CODIGO_ADM == codigo
                              orderby de.FECHA.HasValue descending, de.FECHA
                              select new
                              {
                                  //ID_1 = de == null ? 0 : de.ID,
                                  ID = d.ID,
                                  CODIGO_INT = d.CODIGO_INT,
                                  CODIGO_ADM = d.CODIGO_ADM,
                                  ZONA = d.ZONA,
                                  NOMBRE = d.NOMBRE,
                                  FECHA = SqlFunctions.DateAdd("month", d.CANTIDAD, de.FECHA)

                              };
                    return lst.ToList<dynamic>();
                }
                else
                {
                    var lst = from d in db1.Equipos
                              join e in
                              (
                              from a in db1.Bitacora
                              where a.ASUNTO == "Cambio de aceite"
                              group a by a.ID_EQUIPO into grp
                              select new { ID = grp.Key, FECHA = grp.Max(C => C.FECHA) }
                              )
                              on d.ID equals e.ID into final
                              from de in final.DefaultIfEmpty()
                              where d.CODIGO_ADM == codigo & d.ZONA==zona 
                              orderby de.FECHA.HasValue descending, de.FECHA
                              select new
                              {
                                  //ID_1 = de == null ? 0 : de.ID,
                                  ID = d.ID,
                                  CODIGO_INT = d.CODIGO_INT,
                                  CODIGO_ADM = d.CODIGO_ADM,
                                  ZONA = d.ZONA,
                                  NOMBRE = d.NOMBRE,
                                  FECHA = SqlFunctions.DateAdd("month", d.CANTIDAD, de.FECHA)

                              };
                    return lst.ToList<dynamic>();
                }
            }
        }
        public static List<string> comboBox()
        {
            using (PRODUCCIONEntities db = new PRODUCCIONEntities())
            {
                List<string> y = new List<string>();
                y = (from c in db.Equipos
                     group c by c.ZONA into grp
                     where grp.Count() >= 1
                     select grp.Key).ToList();
                y.Insert(0, "--Ingrese la Ubicación--");
                return y;
            }
        }
        public static List<string> comboBox_actividad(int id)
        {
            using (PRODUCCIONEntities db = new PRODUCCIONEntities())
            {
                List<string> y = new List<string>();
                y = (from c in db.Bitacora
                     where c.ID_EQUIPO==id
                     group c by c.ASUNTO into grp
                     where grp.Count() >= 1
                     select grp.Key).ToList();
                y.Insert(0, "--Ingrese el Asunto--");
                return y;
            }
        }
        public static List<dynamic> actividad(int id)
        {
            using (PRODUCCIONEntities db = new PRODUCCIONEntities())
            {
                var lst =   from d in db.Bitacora
                            where d.ID_EQUIPO==id
                            orderby d.FECHA descending
                            select new {d.ID,d.ASUNTO,d.FECHA};
                return lst.ToList<dynamic>();
            }
        }
        public static List<dynamic> actividadFiltro(int id, string asunto)
        {
            using (PRODUCCIONEntities db = new PRODUCCIONEntities())
            {
                var lst = from d in db.Bitacora
                          where d.ID_EQUIPO == id & d.ASUNTO==asunto
                          orderby d.FECHA descending
                          select new { d.ID, d.ASUNTO, d.FECHA };
                return lst.ToList<dynamic>();
            }
        }
        public static string actividadDetalle(int id)
        {
            using (PRODUCCIONEntities db = new PRODUCCIONEntities())
            {
                var lst = from d in db.Bitacora
                          where d.ID == id
                          select  d.DESCRIPCION ;
                return lst.First().ToString();
            }
        }
        public static List<dynamic> lubricacion(int id)
        {
            using (PRODUCCIONEntities db = new PRODUCCIONEntities())
            {
                var lst = from d in db.Lubricacion
                          where d.ID_EQUIPO == id
                          select new { 
                              d.ID,
                              PUNTOS = d.PTOS_LUB,
                              d.LUBRICANTE,
                              d.TIPO,
                              d.PTO,
                              CANTIDAD_0 = d.CANTIDAD,
                              CANTIDAD = d.LUBRICANTE == "Grasa" & d.CANTIDAD != null ? d.CANTIDAD + " g." : (d.LUBRICANTE == "Aceite" & d.CANTIDAD != null ? d.CANTIDAD + " L." : null),
                              FRECUENCIA = "Cada " + d.TIEMPO + (d.UNIDAD_TIEMPO == 1 ? " dias" : (d.UNIDAD_TIEMPO == 2 ? " meses" : (d.UNIDAD_TIEMPO == 3 ? " años" : null))),
                              d.TIEMPO,
                              UNIDAD_TIEMPO = d.UNIDAD_TIEMPO==1 ? "Dias":(d.UNIDAD_TIEMPO==2 ? "Meses":(d.UNIDAD_TIEMPO==3 ? "Años":null)),
                              d.ESTADO,
                              PRINCIPAL = d.PRINCIPAL == false ? "NO" : (d.PRINCIPAL == true ? "SI":null)
                          };
                return lst.ToList<dynamic>();
            }
        }
        public static void AgregarActividad(int id_equipo, DateTime fecha, string asunto,string descripcion)
        {
            using (PRODUCCIONEntities db = new PRODUCCIONEntities())
            {
                Bitacora b = new Bitacora();
                b.ID_EQUIPO = id_equipo;
                b.FECHA = fecha;
                b.ASUNTO = asunto;
                b.DESCRIPCION = descripcion;
                db.Bitacora.Add(b);
                db.SaveChanges();

            }
        }
        public static void editarActividad(int id, string asunto, DateTime fecha, string descripcion)
        {
            using (PRODUCCIONEntities db = new PRODUCCIONEntities())
            {
                var lst = (from d in db.Bitacora
                          where d.ID == id
                          select d).FirstOrDefault();
                lst.ASUNTO = asunto;
                lst.FECHA = fecha;
                lst.DESCRIPCION= descripcion;
                db.SaveChanges();
            }
        }
        public static bool verificarLubricacionP(int id, int id_lubr)
        {
            using (PRODUCCIONEntities db = new PRODUCCIONEntities())
            {
                var lst = (from d in db.Lubricacion
                          where d.ID_EQUIPO == id & d.PRINCIPAL==true
                          select d).ToList();
                if (lst.Count() > 0 && lst.First().ID !=id_lubr)
                    return true;
                else return false;
            }
        }
        public static void editarLiubricacion(int id,string punto, string lubricante, string tipo, byte? pto, string cantidad, byte? tiempo, byte? unidad_tiempo, string estado, bool? principal)
        {
            using (PRODUCCIONEntities db = new PRODUCCIONEntities())
            {
                var lst = (from d in db.Lubricacion
                          where d.ID == id
                          select d).FirstOrDefault();
                lst.PTOS_LUB = punto;
                lst.LUBRICANTE = lubricante;
                lst.TIPO = tipo;
                lst.PTO = pto;
                lst.CANTIDAD = cantidad;
                lst.TIEMPO = tiempo;
                lst.UNIDAD_TIEMPO = unidad_tiempo;
                lst.ESTADO = estado;
                lst.PRINCIPAL = principal;
                db.SaveChanges();
            }
        }
        public static void editLubricacionP(int id, byte? tiempo, byte? unidad_tiempo)
        {
            using (PRODUCCIONEntities db = new PRODUCCIONEntities())
            {
                var lst = (from d in db.Equipos
                          where d.ID == id
                          select d).FirstOrDefault();
                lst.CANTIDAD = tiempo;
                lst.UNIDAD = unidad_tiempo;
                db.SaveChanges();

            }
        }

    }
}
