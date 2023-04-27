using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercitacion___3
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        public void validarNombre(string nombre)
        {
            if (nombre == "")
            {
                MessageBox.Show("Complete el nombre del alumno");
            }
            else
            {
                Nombre = nombre;
            }
        }
        public void validarApellido(string apellido)
        {
            if (apellido == "")
            {
                MessageBox.Show("Complete el apellido del alumno");
            }
            else
            {
                Apellido = apellido;
            }
        }
        public void validarEdad(int edad)
        {
            if (edad > 16)
            {
                Edad = edad;
            }
            else
            {
                MessageBox.Show("La edad del estudiante no está permitida en esta institución");
            }
        }
        public void validarDireccion(string direccion)
        {
            if (direccion == "")
            {
                MessageBox.Show("Complete la direccion del alumno");
            }
            else
            {
                Direccion = direccion;
            }
        }
        public bool validarDatos(string nombre, string apellido, int edad, string direccion)
        {
            if (nombre == "" || apellido == "" || direccion == "" || edad < 17)
            {
                MessageBox.Show("Complete los datos del alumno");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
