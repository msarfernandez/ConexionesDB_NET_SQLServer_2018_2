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

        public IList<Propiedad> listar()
        {

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
                comando.CommandText = "Select P.IdPropiedad, P.DescripcionGeneral, P.IdDireccion, P.SuperficieCubierta, P.SuperFicieDescubierta, D.Calle, D.Numero  from PROPIEDADES P, DIRECCIONES D Where P.IdDireccion = D.id";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Propiedad();
                    aux.DescripcionGeneral = lector.GetString(1);
                    aux.Id = (int)lector["IdPropiedad"];

                    //Para las columnas que puedan llegar a traer valores nulos. Se puede armar una función aparte.
                    if (!lector.IsDBNull(2))
                    {
                        aux.Direccion = new Direccion();
                        aux.Direccion.Id = (int)lector["IdDireccion"];
                        aux.Direccion.Calle = (string)lector["Calle"];
                        aux.Direccion.Altura = (int)lector["Numero"];
                        
                    }
                    aux.SuperficieCubierta = (int)lector["SuperficieCubierta"];
                    aux.SuperficieDescubierta = (int)lector["SuperficieDescubierta"];

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

        public void alta(Propiedad nuevo)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "insert into PROPIEDADES (DescripcionGeneral, SuperficieCubierta, SuperficieDescubierta, IdDireccion)";
                consulta = consulta + "  values ('" + nuevo.DescripcionGeneral + "'," + nuevo.SuperficieCubierta.ToString() + "," + nuevo.SuperficieDescubierta.ToString() + ",1 )";

                conexion.setearConsulta(consulta);

                conexion.abrirConexion();
                conexion.ejecutarAccion();


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
