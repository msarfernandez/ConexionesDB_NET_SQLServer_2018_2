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
            IList<Propiedad> lista = new List<Propiedad>();
            try
            {
                conexion.ConnectionString = "initial catalog= INMO_DB; data source=.; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from propiedades";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Propiedad aux = new Propiedad();
                    aux.Id = lector.GetInt32(0);
                    aux.DescripcionGeneral = lector.GetString(1);

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
                conexion.Close();
            }

        }

    }
}
