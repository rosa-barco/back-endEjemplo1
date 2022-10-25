﻿using back_endEjemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace back_endEjemplo1.Controllers
{
    public class CalculosController : Controller
    {
        // GET: Calculos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma(string n1, string n2)
        {
            int res = 0;
            res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            ViewBag.res = res;

            return View();
        }

        public ActionResult Operacion(OperasBas op)
        {
            op.Suma();
            return View(op);
        }

        /*public ActionResult Operacion()
        {
            OperasBas op = new OperasBas();
            return View(op);
        }
        [HttpPost] <-- Indica que se pasan parametros a traves de post*/

        public ActionResult Resta()
        {
            return View();
        }
    }
}