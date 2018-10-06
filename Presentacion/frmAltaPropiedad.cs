using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class frmAltaPropiedad : Form
    {
        private Propiedad propiedad = null;

        public frmAltaPropiedad()
        {
            InitializeComponent();
        }
        public frmAltaPropiedad(Propiedad modi)
        {
            InitializeComponent();
            propiedad = modi;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PropiedadNegocio negocio = new PropiedadNegocio();
            DireccionNegocio direccionNegocio = new DireccionNegocio();
            try
            {
                if (propiedad == null)
                    propiedad = new Propiedad();

                propiedad.DescripcionGeneral = txtDescripcion.Text;
                if (txtSuperficieCubierta.Text.Trim() == "" || txtSuperficieDescubierta.Text.Trim() == "")
                {
                    MessageBox.Show("Las superficies son obligatorias");
                    return;
                }
                propiedad.SuperficieCubierta = int.Parse(txtSuperficieCubierta.Text);
                propiedad.SuperficieDescubierta = int.Parse(txtSuperficieDescubierta.Text);

                if (propiedad.Id != 0)
                {
                    negocio.modificar(propiedad);
                    MessageBox.Show("Modificado Correctamente.");
                }
                else
                {
                    propiedad.Direccion.Id = direccionNegocio.agregar(propiedad.Direccion);
                    negocio.alta(propiedad);
                    MessageBox.Show("Agregado Correctamente.");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptarDos_Click(object sender, EventArgs e)
        {
            PropiedadNegocio negocio = new PropiedadNegocio();
            Propiedad nuevo = new Propiedad();
            try
            {
                nuevo.DescripcionGeneral = txtDescripcion.Text;
                if (txtSuperficieCubierta.Text.Trim() == "" || txtSuperficieDescubierta.Text.Trim() == "")
                {
                    MessageBox.Show("Las superficies son obligatorias");
                    return;
                }
                nuevo.SuperficieCubierta = int.Parse(txtSuperficieCubierta.Text);
                nuevo.SuperficieDescubierta = int.Parse(txtSuperficieDescubierta.Text);

                negocio.altaDos(nuevo);

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPropiedad_Load(object sender, EventArgs e)
        {
            try
            {
                if (propiedad != null)
                {
                    txtDescripcion.Text = propiedad.DescripcionGeneral;
                    txtSuperficieCubierta.Text = propiedad.SuperficieCubierta.ToString();
                    txtSuperficieDescubierta.Text = propiedad.SuperficieDescubierta.ToString();
                    Text = "Modificar";
                }
                else
                {
                    //06/10: agrego esto porque por el tema de la direccion necesito que si es ALTA
                    //ya exista de una el objeto PROPIEDAD, no puedo esperar al boton aceptar.
                    propiedad = new Propiedad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            try
            {
                //si aun no tengo una direccon la creo.
                if (propiedad.Direccion == null)
                    propiedad.Direccion = new Direccion();

                //luego se la paso a la ventana de direccion, allá el objeto será
                //cargado y...
                frmDireccion ventanaDireccion = new frmDireccion(propiedad.Direccion);
                ventanaDireccion.ShowDialog();
                //cuando lleguemos acá, con la ventana de dirección cerrada
                //ya voy a tener cargados en propiedad.Direccion esos datos.

                txtDireccion.Text = propiedad.Direccion.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
