using Prode.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prode
{
    public class Equipo : IEquipo
    {
        public int EquipoId;
        public String Descripcion;

        public string nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string abreviatura { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

       
    }
}
