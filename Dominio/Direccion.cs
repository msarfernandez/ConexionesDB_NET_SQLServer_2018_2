﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Direccion
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public int Piso { get; set; }
        public Localidad Localidad { get; set; }

        public override string ToString()
        {
            return Calle + " " + Altura.ToString() + ", " + Piso.ToString() + ", " + Localidad.Descripcion + "(" + Localidad.CP.ToString() + ")";
        }
    }
}
