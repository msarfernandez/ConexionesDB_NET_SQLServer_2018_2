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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            PropiedadNegocio neg = new PropiedadNegocio();
            try
            {
                dgvPropiedades.DataSource = neg.listar();
                dgvPropiedades.Columns[0].Visible = false;
                dgvPropiedades.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvPropiedades.Columns["FechaAlta"].Visible = false;
                //dgvPropiedades.Columns["Direccion"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void btnVerAmbientes_Click(object sender, EventArgs e)
        {
            Propiedad prop;
            prop = (Propiedad)dgvPropiedades.CurrentRow.DataBoundItem;
            frmAmbientes ambientes = new frmAmbientes(prop);
            ambientes.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAltaPropiedad alta = new frmAltaPropiedad();
                alta.ShowDialog();
                //Cuando termino de dar un alta, sigue acá el código...
                //llamo al metodo cargar para re cargar...
                //cargar();
                //otra cosa que pueden hacer es...
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
