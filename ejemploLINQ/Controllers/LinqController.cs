using ejemploLINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploLINQ.Controllers
{
    public class LinqController : Controller
    {
        //instancia de la clase estudiante
        Estudiantes Db = new Estudiantes();
        // GET: Linq

       
        public ActionResult Index()
        {
            
            var listado = Db.Lista();
            return View(listado.ToList());
        }
        [HttpPost]
        public ActionResult Index(string txtbuscar, string select, string rd)
        {
            var listado = Db.Lista();
            string formato = txtbuscar.Trim();
            var query = from a in Db.Lista() select a;
            #region usandoSelect
            if (formato != "")
            {
                if (select == "0")
                {
                    if (select == "1")
                    {
                        query = from n in Db.Lista() where n.Nombre.Contains(formato) select n;
                    }
                    if (select == "2")
                    {
                        query = from n in Db.Lista() where n.Materia.Contains(formato) select n;
                    }
                    if (select == "3")
                    {
                        double prom = Convert.ToDouble(formato);
                        query = from n in Db.Lista() where n.Promedio == prom select n;
                    }
                }

            }
            #endregion
            #region usandoRadio
            if (formato != "")
            {
                if (rd == "1")
                {
                    query = from n in Db.Lista() where n.Nombre.Contains(formato) select n;
                }
                if (rd == "2")
                {
                    query = from n in Db.Lista() where n.Materia.Contains(formato) select n;
                }
                if (rd == "3")
                {
                    double prom = Convert.ToDouble(formato);
                    query = from n in Db.Lista() where n.Promedio == prom select n;
                }
            }
            #endregion

            //var query2 = (from p in listado where p.Materia.Contains(txtbuscar) select p);
            return View(query.ToList());
        }

    }
}