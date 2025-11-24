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
using PracticaBusquedas.Clases;


namespace PracticaBusquedas
{
    public partial class Form1 : Form
    {
        //Ejercicio 1
        int[] arreglo = new int[20];

        //Ejercicio 2
        private List<int> numbers = new List<int>();

        //Ejercicio 3
        private List<Estudiante> estudiantes = new List<Estudiante>();

        //Ejercicio 5
        private List<int> lista5 = new List<int>();

        //Ejercicio 6
        private int[,] matriz6 = new int[10, 10];

        // Generador global de números aleatorios para todos los ejercicios
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
                    MessageBox.Show($"¡Listo mae! El número {numeroBuscado} está en la posición {posicion}");
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
        //Ejercicio 2: Búsqueda de texto dentro de una cadena
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

        //Ejercicio 3: Búsqueda de texto dentro de una cadena

        private void btnBuscarTexto3_Click(object sender, EventArgs e)
        {
            string parrafo = tbParrafo3.Text.Trim();
            string palabra = tbPalabra3.Text.Trim();

            if (string.IsNullOrEmpty(parrafo) || string.IsNullOrEmpty(palabra))
            {
                MessageBox.Show("Meté un párrafo y una palabra mae.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int veces = ContarPalabra(parrafo, palabra);

            MessageBox.Show($"La palabra '{palabra}' aparece {veces} veces.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostrarParrafo3_Click(object sender, EventArgs e)
        {
            lbParrafo3.Items.Clear();
            string parrafo = tbParrafo3.Text.Trim();

            if (string.IsNullOrEmpty(parrafo))
            {
                MessageBox.Show("Meté un párrafo primero mae.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] lineas = parrafo.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string linea in lineas)
            {
                lbParrafo3.Items.Add(linea);
            }

            MessageBox.Show("Parrafo cargado en la lista.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int ContarPalabra(string parrafo, string palabra)
        {
            if (string.IsNullOrEmpty(parrafo) || string.IsNullOrEmpty(palabra))
                return 0;

            parrafo = parrafo.ToLower();
            palabra = palabra.ToLower();
            int contador = 0;

            for (int i = 0; i <= parrafo.Length - palabra.Length; i++)
            {
                bool encontrada = true;
                for (int j = 0; j < palabra.Length; j++)
                {
                    if (parrafo[i + j] != palabra[j])
                    {
                        encontrada = false;
                        break;
                    }
                }
                if (encontrada)
                {
                    contador++;
                }
            }

            return contador;
        }

        //Ejercicio 4:  Búsqueda de objetos en una colección

        private void btnGenerarEstudiantes_Click(object sender, EventArgs e)
        {
            estudiantes.Clear();
            lbEstudiantes4.Items.Clear();

            string[] nombres = { "Ana", "Luis", "Carlos", "Marta", "Juan", "Sofía", "Pedro", "Lucía", "Diego", "Camila" };

            for (int i = 0; i < nombres.Length; i++)
            {
                estudiantes.Add(new Estudiante
                {
                    Id = i + 1,
                    Nombre = nombres[i]
                });
            }

            foreach (var est in estudiantes)
                lbEstudiantes4.Items.Add(est.ToString());

            MessageBox.Show("Lista de estudiantes generada.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnBuscarPorID4.Enabled = true;
            btnBuscarPorNombre4.Enabled = true;
        }

        private void btnBuscarPorID4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbID4.Text.Trim(), out int idBuscado))
            {
                MessageBox.Show("Meté un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Estudiante encontrado = null;
            foreach (var est in estudiantes)
            {
                if (est.Id == idBuscado)
                {
                    encontrado = est;
                    break;
                }
            }

            if (encontrado != null)
                MessageBox.Show($"Estudiante encontrado: {encontrado.Nombre} (ID {encontrado.Id})", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"No se encontró estudiante con ID {idBuscado}.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBuscarPorNombre4_Click(object sender, EventArgs e)
        {
            string nombreBuscado = tbNombre4.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(nombreBuscado))
            {
                MessageBox.Show("Meté un nombre para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ordenar alfabéticamente por nombre
            estudiantes.Sort((a, b) => a.Nombre.CompareTo(b.Nombre));

            int left = 0;
            int right = estudiantes.Count - 1;
            Estudiante encontrado = null;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int cmp = string.Compare(estudiantes[mid].Nombre.ToLower(), nombreBuscado);

                if (cmp == 0)
                {
                    encontrado = estudiantes[mid];
                    break;
                }
                else if (cmp < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            if (encontrado != null)
                MessageBox.Show($"Estudiante encontrado: {encontrado.Nombre} (ID {encontrado.Id})", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"No se encontró estudiante con el nombre '{nombreBuscado}'.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Ejercicio 5: Búsqueda del valor máximo y mínimo
        private void btnGenerarLista5_Click(object sender, EventArgs e)
        {
            lista5.Clear();
            lbLista5.Items.Clear();

            // Generar 20 números aleatorios
            for (int i = 0; i < 20; i++)
            {
                int num = rnd.Next(1, 101);
                lista5.Add(num);
                lbLista5.Items.Add(num);
            }

            MessageBox.Show("Lista generada mae.", "Confirmación",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarMazMin5_Click(object sender, EventArgs e)
        {
            if (lista5.Count == 0)
            {
                MessageBox.Show("Generá la lista primero chele.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int max = lista5[0];
            int min = lista5[0];
            int iteraciones = 0;

            // Recorrido manual SIN usar Max() ni Min()
            for (int i = 0; i < lista5.Count; i++)
            {
                int valor = lista5[i];
                iteraciones++;

                if (valor > max)
                    max = valor;

                if (valor < min)
                    min = valor;
            }

            MessageBox.Show(
                $"Valor máximo: {max}\n" +
                $"Valor mínimo: {min}\n" +
                $"Iteraciones realizadas: {iteraciones}",
                "Resultado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnGenerarMatriz6_Click(object sender, EventArgs e)
        {
            // Evitar fila de edición al final que desordena los índices
            dgMatriz6.AllowUserToAddRows = false;
            dgMatriz6.Rows.Clear();
            dgMatriz6.Columns.Clear();

            // Crear exactamente 10 columnas
            for (int c = 0; c < 10; c++)
            {
                dgMatriz6.Columns.Add("C" + c, (c + 1).ToString()); // encabezado visible 1..10
            }

            // Añadir 10 filas
            dgMatriz6.RowCount = 10;

            // Llenar la matriz y el grid
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz6[i, j] = rnd.Next(1, 101);
                    dgMatriz6.Rows[i].Cells[j].Value = matriz6[i, j];
                    // Resetear color por si quedó resaltado de búsquedas previas
                    dgMatriz6.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }

            MessageBox.Show("Matriz 10x10 generada.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarMatriz6_Click(object sender, EventArgs e)
        {
            // Validar entrada
            if (!int.TryParse(tbNumero6.Text.Trim(), out int objetivo))
            {
                MessageBox.Show("Meté un número válido pues.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Asegurarse de que el grid tenga exactamente 10x10
            int filas = dgMatriz6.RowCount;
            int columnas = dgMatriz6.ColumnCount;

            bool encontrado = false;
            int iteraciones = 0;
            List<string> posiciones = new List<string>();

            // Limpiar resaltados previos
            for (int r = 0; r < filas; r++)
                for (int c = 0; c < columnas; c++)
                    dgMatriz6.Rows[r].Cells[c].Style.BackColor = Color.White;

            // Recorrido exhaustivo: recorrer la matriz y el grid por los mismos índices
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    iteraciones++;

                    object cellVal = dgMatriz6.Rows[i].Cells[j].Value;
                    if (cellVal == null) continue;

                    if (int.TryParse(cellVal.ToString(), out int valor))
                    {
                        if (valor == objetivo)
                        {
                            encontrado = true;
                            // Resaltar celda
                            dgMatriz6.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                            // Guardar posición en formato humano (1-based)
                            posiciones.Add($"(fila {i + 1}, col {j + 1})");
                        }
                    }
                }
            }

            // Mostrar resultado
            if (encontrado)
            {
                string posText = string.Join(", ", posiciones);
                MessageBox.Show($"Número {objetivo} encontrado en: {posText}\nIteraciones: {iteraciones}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No encontré el número {objetivo}.\nIteraciones: {iteraciones}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
