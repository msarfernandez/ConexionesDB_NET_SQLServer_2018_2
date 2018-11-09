using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoUsuario
    {
        public const int ADMINISTRADOR = 1;
        public const int GERENTE = 2;
        public const int ATENCION_PUBLICO = 3;

        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
