using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Localidad
    {
        public int IdLocalidad { get; set; }
        public string CP { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion + "(" + CP.ToString() + ")";
        }
    }
}
