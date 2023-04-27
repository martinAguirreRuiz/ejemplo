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
    public partial class frmTabla : Form
    {
        public frmTabla()
        {
            InitializeComponent();
        }

        public void AgregarEstudiantesAlListView (List<Estudiante> listaEstudiantes)
        {
            foreach (Estudiante estudiante in listaEstudiantes)
            {
                ListViewItem item = new ListViewItem(estudiante.Nombre);
                item.SubItems.Add(estudiante.Apellido);
                item.SubItems.Add(estudiante.Edad.ToString());
                item.SubItems.Add(estudiante.Direccion);
                listViewEstudiantes.Items.Add(item);
            }
        }



        //public void agregarEstudiante(Estudiante estudiante)
        //{
        //    listViewEstudiantes.Columns.Add(estudiante.Nombre);
        //    listViewEstudiantes.Columns.Add(estudiante.Apellido);
        //    listViewEstudiantes.Columns.Add(estudiante.Edad.ToString());
        //    listViewEstudiantes.Columns.Add(estudiante.Direccion);

        //}
    }
}
