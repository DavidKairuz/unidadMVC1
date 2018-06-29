using System;
using System.Collections.Generic;
using System.Text;

namespace Prode
{
    public class Partido
    {
        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public int GolesVisitante { get; set; }
        public int GolesLocal { get; set; }
        public DateTime Fecha { get; set; }
        public String InformacionResultado {
        //  Equipo Equipolocal = new Equipo

        get { var resultado = "";
                if (GolesLocal > GolesVisitante)
                {

                    resultado = $"Gano {0} { EquipoLocal.Descripcion}";
                }
                else if (GolesLocal < GolesVisitante)
                {
                    resultado = $"Gano {0} { EquipoVisitante.Descripcion}";

                }
                else
                {
                    resultado = "Empate";
                }
                return resultado;
       
    }
}
    }
}
