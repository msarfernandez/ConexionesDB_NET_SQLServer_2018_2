using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Propiedad
    {
        public int Id { get; set; }
        public string DescripcionGeneral { get; set; }
        public int SuperficieCubierta { get; set; }
        public int SuperficieDescubierta { get; set; }
        public int Ambientes { get; set; }
        public Direccion Direccion { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
