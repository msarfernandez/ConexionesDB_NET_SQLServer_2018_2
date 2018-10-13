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
        private string descripcion;

        public string Descripcion
        {
            set
            {
                descripcion = value;
                DescripcionGeneral = ToString();
            }
            get { return descripcion; }
        }

        public string DescripcionGeneral { get; set; }


        public override string ToString()
        {
            return Descripcion + "(" + CP.ToString() + ")";
        }

        private void metodo()
        {
            Localidad algo = new Localidad();
            algo.Descripcion = "HOLA";
        }
    }


}
