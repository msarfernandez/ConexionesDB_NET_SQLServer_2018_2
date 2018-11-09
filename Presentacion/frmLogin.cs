using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmLogin : Form
    {

        private Usuario usuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(usuario.Id == 0){
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            try
            {
                usuario.NombreUsuario = txtUsuario.Text.Trim();
                usuario.Pass = txtPass.Text.Trim();
                if (usuarioNegocio.validarUsuario(usuario))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("usuario o pass incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
