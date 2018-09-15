using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ambient
    {
        public int Id { get; set; }
        public int IdPropiedad { get; set; }
        public string Descripcion { get; set; }

        public Ambient() { }
        public Ambient(int id, int idPropiedad, string desc) {
            Id = id;
            IdPropiedad = idPropiedad;
            Descripcion = desc;
        }
    }
}
