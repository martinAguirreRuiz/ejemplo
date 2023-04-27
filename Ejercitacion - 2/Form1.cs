using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercitacion___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text == "")
            {
                MessageBox.Show("Ingrese los números pedidos");
            }
            else
            {

            string texto = txtNumeros.Text;
            string[] textoSeparado = texto.Split(',');

            List<int> numerosPares = new List<int>();
            List<int> numerosImpares = new List<int>();
            List<int> numeros = new List<int>();

            for (int i = 0; i < textoSeparado.Length; i++)
            {
                numeros.Add(int.Parse(textoSeparado[i]));

                if (int.Parse(textoSeparado[i]) % 2 == 0)
                {
                    numerosPares.Add(int.Parse(textoSeparado[i]));
                }
                else
                {
                    numerosImpares.Add(int.Parse(textoSeparado[i]));
                }
            }


            if (numerosPares.Count == 1)
            {
                txtResultado.Text = ("Se ingresó " + numerosPares.Count + " números par");
            }
            else
            {
                txtResultado.Text = ("Se ingresaron " + numerosPares.Count + " números pares");
            }
            if (numerosImpares.Count == 1)
            {
                txtResultado.Text = (txtResultado.Text + "\r\nSe ingresó " + numerosImpares.Count + " número impar");
            }
            else
            {
                txtResultado.Text = (txtResultado.Text + "\r\nSe ingresaron " + numerosImpares.Count + " números impares");
            }
            txtResultado.Text = txtResultado.Text + "\r\nNúmeros ordenados en forma descendente: ";

            numeros.Sort((a, b) => b.CompareTo(a)); // Mayor a menor

            int x = 0;

            foreach (int item in numeros)
            {
                x++;

                if (x == numeros.Count)
                {
                    txtResultado.Text = txtResultado.Text + item;

                }
                else
                {
                    txtResultado.Text = txtResultado.Text + item + " - ";
                }
            }

            txtResultado.Text = txtResultado.Text + "\r\nNúmeros ordenados en forma ascendente: ";
            
            numeros.Sort((a, b) => a.CompareTo(b)); // Menor a mayor

            x = 0;

            foreach (int item in numeros)
            {
                x++;

                if (x == numeros.Count)
                {
                    txtResultado.Text = txtResultado.Text + item;

                }
                else
                {
                    txtResultado.Text = txtResultado.Text + item + " - ";
                }
            }

            }
            

        }
    }
}


