using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PracticaBusquedas
{
    public partial class Form1 : Form
    {
        int[] arreglo = new int[20];
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            

        }

        private void tb1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rnd.Next(1, 101);
            }

            lblNumeros.Text = string.Join(", ", arreglo);


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbBuscar.Text, out int numeroBuscado))
            {
                int posicion = -1;

                // Búsqueda lineal, recorriendo todo el arreglo
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (arreglo[i] == numeroBuscado)
                    {
                        posicion = i;
                        break; // se encontró, ya no hay que seguir buscando
                    }
                }

                // Mensajes bien nicas
                if (posicion != -1)
                    MessageBox.Show($"¡Listo, mae! El número {numeroBuscado} está en la posición {posicion}");
                else
                    MessageBox.Show($"Broder, no encontré el número {numeroBuscado} en el arreglo");
            }
            else
            {
                MessageBox.Show("Oe, escribí un número válido en el cuadro, no te me enredés.");
            }
        }
    
    }
}
