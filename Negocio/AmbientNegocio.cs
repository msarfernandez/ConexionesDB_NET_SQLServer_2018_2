using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    class AmbientNegocio
    {
        //Metodo que devuelve una lista de ambientes.
        //si le paso un idPropiedad, busco  por propiedad
        //si no se lo paso, toma cero, en ese caso busco todo
        public List<Ambient> listar(int idPropiedad = 0)
        {
            //lista a ser devuelta.
            List<Ambient> lista = new List<Ambient>();
            //creo la conexion directamente con la cadena de conexion
            SqlConnection conexion = new SqlConnection("initial catalog=INMO_DB; data source=.; integrated security=sspi");
            //creo el comando directamente con el command text y la conexion. Todo pasado por constructor.
            SqlCommand comando = new SqlCommand("select id, descripcion, idPropiedad from ambientes", conexion);
            //lector para los datos leidos.
            SqlDataReader lector;
            try
            {
                //asigno tipo de comando a utilizar. TEXT para una consulta simple embebida.
                comando.CommandType = System.Data.CommandType.Text;

                //Si me vino un idPropiedad informado en el metodo
                //agrego un where a la consulta original.
                if (idPropiedad > 0)
                    comando.CommandText = comando.CommandText + " Where idPropiedad=" + idPropiedad.ToString();

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    //creo un ambiente al que directamente por constructor
                    //le estoy pasando los datos del lector, de la consulta SQL de arriba.
                    Ambient aux = new Ambient(lector.GetInt32(0), lector.GetInt32(2), lector.GetString(1));
                    lista.Add(aux);
                }

                //return de la lista que creé arriba, antes del TRY.
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                conexion.Close();
            }
        }

    }
}
