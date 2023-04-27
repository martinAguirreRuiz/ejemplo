using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercitacion_1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text != "" && txtDireccion.Text != "" && txtNombre.Text != "" && numericEdad.Value != 0)
            {
            if (txtResultado.Text != "")
            {
                txtResultado.Text = "";
            }
            txtResultado.Text = "Este es " + txtNombre.Text + " " + txtApellido.Text + ", a día de hoy tiene " + numericEdad.Value + " años, y vive en " + txtDireccion.Text;

            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }
    }
}
