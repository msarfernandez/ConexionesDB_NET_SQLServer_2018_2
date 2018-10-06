using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DireccionNegocio
    {
        public int agregar(Direccion direccion)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("Insert into DIRECCIONES output inserted.Id Values (@Calle, @Numero, @Piso, @IdLocalidad)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Calle", direccion.Calle);
                conexion.Comando.Parameters.AddWithValue("@Numero", direccion.Altura);
                conexion.Comando.Parameters.AddWithValue("@Piso", direccion.Piso);
                conexion.Comando.Parameters.AddWithValue("@IdLocalidad", direccion.Localidad.IdLocalidad);

                conexion.abrirConexion();
                return conexion.ejecutarAccionReturn();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
