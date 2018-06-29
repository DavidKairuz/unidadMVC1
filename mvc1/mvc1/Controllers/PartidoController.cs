using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prode;

namespace mvc1.Controllers
{
    public class PartidoController : Controller
    {
        // GET: Partido
        public ActionResult Index()
        {
            return View();
        }

        // GET: Partido/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Partido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Partido/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Partido/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Partido/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Partido/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        public ActionResult ResultadoPartido (){//este agregamos en clase,para instanciar los objetos de la clase partido y equipo

            Equipo equipo1 = new Prode.Equipo //instancio y seteo los valores
            {
                EquipoId = 1,
               Descripcion = "Argentina"
            };

            Equipo equipo2 = new Equipo {}; //instancio y luego le asigno a los atributos los valores

                equipo2.EquipoId = 2;
                equipo2.Descripcion = "Nigeria";


            Partido partido = new Partido
            {
                EquipoLocal = equipo1,
                EquipoVisitante = equipo2,
                GolesLocal = 2,
                GolesVisitante = 1
            };
            var x = partido.InformacionResultado;

            ViewData["EquipoLocal"] = partido.EquipoLocal.Descripcion;
            ViewData["EquipoVisitante"] = partido.EquipoVisitante.Descripcion;
            ViewData["Result"] = partido.InformacionResultado;
            ViewBag.MostrarResultado = true;
            return View("Resultado",partido);
        }

        // POST: Partido/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}