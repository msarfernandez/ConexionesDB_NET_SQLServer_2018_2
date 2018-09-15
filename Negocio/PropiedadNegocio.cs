using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class PropiedadNegocio
    {

        public IList<Propiedad> listar() {

            //conexion
            SqlConnection conexion = new SqlConnection();
            //sentencia
            SqlCommand comando = new SqlCommand();
            //objeto de recepcion
            SqlDataReader lector;
            //lista
            IList<Propiedad> lista = new List<Propiedad>();
            Propiedad aux;

            //CLASE 6: agrego un objeto nuevo
            AmbientNegocio ambientNegocio = new AmbientNegocio();

            try
            {
                conexion.ConnectionString = "initial catalog= INMO_DB; data source=.; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select IdPropiedad, DescripcionGeneral from PROPIEDADES";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Propiedad();
                    aux.DescripcionGeneral = lector.GetString(1);
                    aux.Id = (int)lector["IdPropiedad"];
                    //en la property AMBIENTES guardo todos sus ambientes.
                    aux.Ambientes = ambientNegocio.listar(aux.Id);
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
                //lector.Close();
                lector = null;
                conexion.Close();
            }

        }

    }
}
