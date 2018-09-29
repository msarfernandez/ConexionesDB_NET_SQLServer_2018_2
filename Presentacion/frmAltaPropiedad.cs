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
        public frmAltaPropiedad()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
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

                negocio.alta(nuevo);

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
