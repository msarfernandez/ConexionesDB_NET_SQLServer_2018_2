using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsbPropiedades_Click(object sender, EventArgs e)
        {
            foreach (Form juanCarlos in Application.OpenForms)
            {
                if (juanCarlos.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya está abierta...");
                    return;
                }
            }
            //Creo una ventana y le digo quién es su padre.
            Form1 propiedades = new Form1();
            propiedades.MdiParent = this;
            //La muestro en pantalla.
            propiedades.Show();

            //Esto es para preguntar por una ventana y su tipo.
            //if (propiedades.GetType() == typeof(Form1))
            //    MessageBox.Show("ya tenes una abierta");

        }
    }
}
