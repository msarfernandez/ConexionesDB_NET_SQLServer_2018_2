using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class LocalidadNegocio
    {
        public List<Localidad> listar()
        {
            AccesoDatos conexion = null;
            List<Localidad> lista = new List<Localidad>();
            Localidad aux;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("Select IdLocalidad, CP, Descripcion From Localidades");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                while (conexion.Lector.Read())
                {
                    aux = new Localidad();
                    aux.IdLocalidad = (int)conexion.Lector["IdLocalidad"];
                    aux.CP = (string)conexion.Lector["CP"];
                    aux.Descripcion = (string)conexion.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.cerrarConexion();
            }
        }
    }
}
