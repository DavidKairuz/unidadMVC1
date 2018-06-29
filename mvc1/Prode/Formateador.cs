using Prode.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prode
{
    class Formateador : Iformateador
    {
        private string _id;
        public Formateador()
        {
            _id = Guid.NewGuid().ToString();
        }

        public string nombreCompleto(IEquipo equipo)
        {
            return $"Nombre completo { equipo.nombre} ({equipo.abreviatura }) { _id}";
        }

    }
       
}
