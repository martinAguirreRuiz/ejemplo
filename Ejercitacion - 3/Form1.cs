using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercitacion___3
{
    public partial class frmPrincipal : Form
    {
        List<Estudiante> listaEstudiantes;

        public frmPrincipal()
        {
            InitializeComponent();
            listaEstudiantes = new List<Estudiante>();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.validarNombre(txtNombre.Text);
            estudiante.validarApellido(txtApellido.Text);
            estudiante.validarEdad(Convert.ToInt32(numEdad.Value));
            estudiante.validarDireccion(txtDireccion.Text);

            if (estudiante.validarDatos(txtNombre.Text, txtApellido.Text, Convert.ToInt32(numEdad.Value), txtDireccion.Text))
            {
                listaEstudiantes.Add(estudiante);
            }

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            numEdad.Value = 0;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmTabla tabla = new frmTabla();
            tabla.AgregarEstudiantesAlListView(listaEstudiantes);
            tabla.ShowDialog();
        }
    }
}
