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
            PropiedadNegocio neg = new PropiedadNegocio();
            try
            {
                dgvPropiedades.DataSource = neg.listar();
                dgvPropiedades.Columns[2].Visible = false;
                dgvPropiedades.Columns["FechaAlta"].Visible = false;
                dgvPropiedades.Columns["Direccion"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
