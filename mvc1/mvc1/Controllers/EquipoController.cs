using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prode;
using Prode.Interfaces;

namespace mvc1.Controllers
{
    public class EquipoController : Controller
    {
        private Iformateador _formateador;
        public EquipoController(Iformateador formateador)
        {
            _formateador = formateador;
          
        }

        public IActionResult Index()
        {
            var argentina = new Equipo()
            {
                Descripcion = "Argentina"
            };

           // IEquipo argentina;
            ViewData["Nombre"] = _formateador.nombreCompleto(argentina);
            return View();
        }
    }
}