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

namespace Presentacion
{
    public partial class frmAmbientes : Form
    {
        private Propiedad propiedad;

        public frmAmbientes()
        {
            InitializeComponent();
        }
        public frmAmbientes(Propiedad prop)
        {
            InitializeComponent();
            propiedad = prop;
        }

        private void frmAmbientes_Load(object sender, EventArgs e)
        {
            dgvAmbientes.DataSource = propiedad.Ambientes;
        }
    }
}
