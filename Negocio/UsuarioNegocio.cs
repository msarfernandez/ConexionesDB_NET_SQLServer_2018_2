using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public bool validarUsuario(Usuario usuario)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select Id, Usuario, Pass, IdTipoUsuario from USUARIOS Where Usuario=@usuario and Pass=@pass");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
                conexion.Comando.Parameters.AddWithValue("@pass", usuario.Pass);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                if (conexion.Lector.Read())
                {
                    usuario.Id = (int)conexion.Lector["Id"];
                    usuario.NombreUsuario = (string)conexion.Lector["Usuario"];
                    usuario.Pass = (string)conexion.Lector["Pass"];
                    usuario.Tipo = new TipoUsuario();
                    usuario.Tipo.Id = (int)conexion.Lector["IdTipoUsuario"];
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
