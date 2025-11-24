using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PracticaBusquedas
{
    public partial class Form1 : Form
    {
        //Ejercicio 1
        int[] arreglo = new int[20];

        //Ejercicio 2
        private List<int> numbers = new List<int>();

        Random rnd = new Random();

        
        

        public Form1()
        {
            InitializeComponent();

            btnOrdenar2.Enabled = false;
            btnBuscar2.Enabled = false;
            lblResultado2.Text = "";
        }

        private void tb1_Click(object sender, EventArgs e)
        {

        }
        //Ejercicio 1
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

        private void NumAleatorios_Click(object sender, EventArgs e)
        {

        }
        //Ejercicio 2
        private void btnGenerar2_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            lbNumeros2.Items.Clear();

            for (int i = 0; i < 30; i++)
            {
                numbers.Add(rnd.Next(1, 101)); // 1..100
            }

            // MOSTRAR LA LISTA EN EL LISTBOX
            DisplayNumbersInListBox();

            // Habilitamos botones
            btnOrdenar2.Enabled = true;   // ya está ordenada al mostrar
            btnBuscar2.Enabled = true;
            lblResultado2.Text = "Lista generada.";
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            lblResultado2.Text = "";

            if (numbers == null || numbers.Count == 0)
            {
                MessageBox.Show("Primero generá y ordená la lista pues.");
                return;
            }

            if (!int.TryParse(tbBuscar2.Text.Trim(), out int objetivo))
            {
                MessageBox.Show("Meté un número válido para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int left = 0;
            int right = numbers.Count - 1;
            bool encontrado = false;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int midVal = numbers[mid];

                // Opcional: seleccionar visualmente el elemento medio en el ListBox
                if (mid >= 0 && mid < lbNumeros2.Items.Count)
                {
                    lbNumeros2.SelectedIndex = mid;
                }

                if (midVal == objetivo)
                {
                    encontrado = true;
                    lblResultado2.Text = $"Encontrado en índice {mid} (valor {midVal}).";
                    MessageBox.Show($"Número {objetivo} encontrado en índice {mid} (valor {midVal}).");
                    break;
                }
                else if (objetivo < midVal)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            if (!encontrado)
            {
                lblResultado2.Text = "No encontrado.";
                MessageBox.Show("Ese número no está en la lista loco.");
                lbNumeros2.ClearSelected();
            }
        }

        private void DisplayNumbersInListBox()
        {
            lbNumeros2.Items.Clear();
            for (int i = 0; i < numbers.Count; i++)
            {
                lbNumeros2.Items.Add(numbers[i]); // si querés mostrar índice: $"{i}: {numbers[i]}"
            }
        }

        private void btnOrdenar2_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            DisplayNumbersInListBox();
            btnOrdenar2.Enabled = false;
            btnBuscar2.Enabled = true;
            lblResultado2.Text = "Lista ordenada.";
        }
    }
}
