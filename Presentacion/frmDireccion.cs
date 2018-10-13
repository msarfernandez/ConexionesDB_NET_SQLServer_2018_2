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
    public partial class frmDireccion : Form
    {
        private Direccion direccion;

        public frmDireccion()
        {
            InitializeComponent();
        }

        public frmDireccion(Direccion direccion)
        {
            InitializeComponent();
            this.direccion = direccion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                direccion.Calle = txtCalle.Text;
                direccion.Altura = int.Parse(txtNumero.Text);
                direccion.Piso = int.Parse(txtPiso.Text);
                direccion.Localidad = (Localidad)cboLocalidad.SelectedItem;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmDireccion_Load(object sender, EventArgs e)
        {
            LocalidadNegocio negocioLocalidad = new LocalidadNegocio();
            try
            {
                cboLocalidad.DataSource = negocioLocalidad.listar();
                cboLocalidad.DisplayMember = "DescripcionGeneral";
                cboLocalidad.ValueMember = "IdLocalidad";

                if(direccion.Id != 0)
                {
                    txtCalle.Text = direccion.Calle;
                    txtNumero.Text = direccion.Altura.ToString();
                    txtPiso.Text = direccion.Piso.ToString();
                    cboLocalidad.SelectedValue = direccion.Localidad.IdLocalidad;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
