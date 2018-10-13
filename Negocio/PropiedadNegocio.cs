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
                comando.CommandText = "Select P.IdPropiedad, P.DescripcionGeneral, P.IdDireccion, P.SuperficieCubierta, P.SuperFicieDescubierta, D.Calle, D.Numero, D.Piso, D.IdLocalidad, L.CP, L.Descripcion as Loc  from PROPIEDADES P, DIRECCIONES D, LOCALIDADES L Where P.IdDireccion = D.id And Activo = 1 And D.IdLocalidad = L.IdLocalidad";
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
                        aux.Direccion.Piso = (int)lector["Piso"];
                        aux.Direccion.Localidad = new Localidad();
                        aux.Direccion.Localidad.IdLocalidad = (int)lector["IdLocalidad"];
                        aux.Direccion.Localidad.CP = (string)lector["CP"];
                        aux.Direccion.Localidad.Descripcion = (string)lector["Loc"];

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

        public void modificar(Propiedad propiedad)
        {
            AccesoDatos conexion;
            DireccionNegocio direccionNegocio = new DireccionNegocio();
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("update PROPIEDADES set DescripcionGeneral = @descripcion, SuperficieCubierta = @supCubierta, SuperficieDescubierta = @supDescubierta Where IdPropiedad = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@descripcion", propiedad.DescripcionGeneral);
                conexion.Comando.Parameters.AddWithValue("@supCubierta", propiedad.SuperficieCubierta);
                conexion.Comando.Parameters.AddWithValue("@supDescubierta", propiedad.SuperficieDescubierta);
                conexion.Comando.Parameters.AddWithValue("@id", propiedad.Id);

                conexion.abrirConexion();
                conexion.ejecutarAccion();

                direccionNegocio.modificar(propiedad.Direccion);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void altaDos(Propiedad nuevo)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("insert into PROPIEDADES (DescripcionGeneral, SuperficieCubierta, SuperficieDescubierta, IdDireccion, Activo) values (@descripcion, @supCubierta, @supDescubierta, 1, 1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@descripcion", nuevo.DescripcionGeneral);
                conexion.Comando.Parameters.AddWithValue("@supCubierta", nuevo.SuperficieCubierta);
                conexion.Comando.Parameters.AddWithValue("@supDescubierta", nuevo.SuperficieDescubierta);

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

        public void alta(Propiedad nuevo)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "insert into PROPIEDADES (DescripcionGeneral, SuperficieCubierta, SuperficieDescubierta, IdDireccion, Activo)";
                consulta = consulta + " values ('" + nuevo.DescripcionGeneral + "'," + nuevo.SuperficieCubierta.ToString() + "," + nuevo.SuperficieDescubierta.ToString() + "," + nuevo.Direccion.Id.ToString() + ", 1)";

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

        public void eliminarFisico(int id)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("Delete From PROPIEDADES Where IdPropiedad=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void eliminarLogico(int id)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("Update Propiedades Set Activo = 0 Where IdPropiedad=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            { 
            
                throw ex;
            }
        }
    }
}
