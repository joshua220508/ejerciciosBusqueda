namespace PracticaBusquedas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ejercicio2 = new System.Windows.Forms.TabControl();
            this.tb1 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TabPage();
            this.btnOrdenar2 = new System.Windows.Forms.Button();
            this.btnGenerar2 = new System.Windows.Forms.Button();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.lbNumeros2 = new System.Windows.Forms.ListBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.tbBuscar2 = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TabPage();
            this.btnMostrarParrafo3 = new System.Windows.Forms.Button();
            this.lbParrafo3 = new System.Windows.Forms.ListBox();
            this.btnBuscarTexto3 = new System.Windows.Forms.Button();
            this.tbPalabra3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbParrafo3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TabPage();
            this.btnBuscarPorNombre4 = new System.Windows.Forms.Button();
            this.btnBuscarPorID4 = new System.Windows.Forms.Button();
            this.btnGenerarEstudiantes = new System.Windows.Forms.Button();
            this.tbNombre4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbID4 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEstudiantes4 = new System.Windows.Forms.ListBox();
            this.tb5 = new System.Windows.Forms.TabPage();
            this.tb6 = new System.Windows.Forms.TabPage();
            this.lbLista5 = new System.Windows.Forms.ListBox();
            this.btnGenerarLista5 = new System.Windows.Forms.Button();
            this.btnBuscarMazMin5 = new System.Windows.Forms.Button();
            this.dgMatriz6 = new System.Windows.Forms.DataGridView();
            this.tbNumero6 = new System.Windows.Forms.TextBox();
            this.btnGenerarMatriz6 = new System.Windows.Forms.Button();
            this.btnBuscarMatriz6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Ejercicio2.SuspendLayout();
            this.tb1.SuspendLayout();
            this.tb2.SuspendLayout();
            this.tb3.SuspendLayout();
            this.tb4.SuspendLayout();
            this.tb5.SuspendLayout();
            this.tb6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz6)).BeginInit();
            this.SuspendLayout();
            // 
            // Ejercicio2
            // 
            this.Ejercicio2.Controls.Add(this.tb1);
            this.Ejercicio2.Controls.Add(this.tb2);
            this.Ejercicio2.Controls.Add(this.tb3);
            this.Ejercicio2.Controls.Add(this.tb4);
            this.Ejercicio2.Controls.Add(this.tb5);
            this.Ejercicio2.Controls.Add(this.tb6);
            this.Ejercicio2.Location = new System.Drawing.Point(37, 45);
            this.Ejercicio2.Name = "Ejercicio2";
            this.Ejercicio2.SelectedIndex = 0;
            this.Ejercicio2.Size = new System.Drawing.Size(701, 387);
            this.Ejercicio2.TabIndex = 0;
            // 
            // tb1
            // 
            this.tb1.Controls.Add(this.btnBuscar);
            this.tb1.Controls.Add(this.label2);
            this.tb1.Controls.Add(this.tbBuscar);
            this.tb1.Controls.Add(this.btnGenerar);
            this.tb1.Controls.Add(this.lblNumeros);
            this.tb1.Controls.Add(this.label1);
            this.tb1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb1.Location = new System.Drawing.Point(4, 29);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(693, 354);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Ejercicio1";
            this.tb1.UseVisualStyleBackColor = true;
            this.tb1.Click += new System.EventHandler(this.tb1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(269, 178);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 39);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar Numero";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(26, 184);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(177, 26);
            this.tbBuscar.TabIndex = 3;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(269, 15);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(104, 39);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeros.Location = new System.Drawing.Point(26, 57);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(127, 22);
            this.lblNumeros.TabIndex = 1;
            this.lblNumeros.Text = "                             ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeros Random:";
            // 
            // tb2
            // 
            this.tb2.Controls.Add(this.btnOrdenar2);
            this.tb2.Controls.Add(this.btnGenerar2);
            this.tb2.Controls.Add(this.lblResultado2);
            this.tb2.Controls.Add(this.lbNumeros2);
            this.tb2.Controls.Add(this.btnBuscar2);
            this.tb2.Controls.Add(this.tbBuscar2);
            this.tb2.Controls.Add(this.lblBuscar);
            this.tb2.Controls.Add(this.label3);
            this.tb2.Location = new System.Drawing.Point(4, 29);
            this.tb2.Name = "tb2";
            this.tb2.Padding = new System.Windows.Forms.Padding(3);
            this.tb2.Size = new System.Drawing.Size(693, 354);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "Ejercicio2";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar2
            // 
            this.btnOrdenar2.Location = new System.Drawing.Point(301, 103);
            this.btnOrdenar2.Name = "btnOrdenar2";
            this.btnOrdenar2.Size = new System.Drawing.Size(108, 40);
            this.btnOrdenar2.TabIndex = 11;
            this.btnOrdenar2.Text = "Ordenar";
            this.btnOrdenar2.UseVisualStyleBackColor = true;
            this.btnOrdenar2.Click += new System.EventHandler(this.btnOrdenar2_Click);
            // 
            // btnGenerar2
            // 
            this.btnGenerar2.Location = new System.Drawing.Point(301, 34);
            this.btnGenerar2.Name = "btnGenerar2";
            this.btnGenerar2.Size = new System.Drawing.Size(108, 40);
            this.btnGenerar2.TabIndex = 10;
            this.btnGenerar2.Text = "Generar";
            this.btnGenerar2.UseVisualStyleBackColor = true;
            this.btnGenerar2.Click += new System.EventHandler(this.btnGenerar2_Click);
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Location = new System.Drawing.Point(38, 247);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(137, 20);
            this.lblResultado2.TabIndex = 9;
            this.lblResultado2.Text = "                                ";
            // 
            // lbNumeros2
            // 
            this.lbNumeros2.FormattingEnabled = true;
            this.lbNumeros2.ItemHeight = 20;
            this.lbNumeros2.Location = new System.Drawing.Point(452, 84);
            this.lbNumeros2.Name = "lbNumeros2";
            this.lbNumeros2.Size = new System.Drawing.Size(212, 244);
            this.lbNumeros2.TabIndex = 7;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(301, 175);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(108, 40);
            this.btnBuscar2.TabIndex = 6;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // tbBuscar2
            // 
            this.tbBuscar2.Location = new System.Drawing.Point(31, 189);
            this.tbBuscar2.Name = "tbBuscar2";
            this.tbBuscar2.Size = new System.Drawing.Size(178, 26);
            this.tbBuscar2.TabIndex = 5;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(26, 142);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(93, 29);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numeros Aleatorios";
            // 
            // tb3
            // 
            this.tb3.Controls.Add(this.btnMostrarParrafo3);
            this.tb3.Controls.Add(this.lbParrafo3);
            this.tb3.Controls.Add(this.btnBuscarTexto3);
            this.tb3.Controls.Add(this.tbPalabra3);
            this.tb3.Controls.Add(this.label5);
            this.tb3.Controls.Add(this.tbParrafo3);
            this.tb3.Controls.Add(this.label4);
            this.tb3.Location = new System.Drawing.Point(4, 29);
            this.tb3.Name = "tb3";
            this.tb3.Padding = new System.Windows.Forms.Padding(3);
            this.tb3.Size = new System.Drawing.Size(693, 354);
            this.tb3.TabIndex = 2;
            this.tb3.Text = "Ejercicio3";
            this.tb3.UseVisualStyleBackColor = true;
            // 
            // btnMostrarParrafo3
            // 
            this.btnMostrarParrafo3.Location = new System.Drawing.Point(44, 266);
            this.btnMostrarParrafo3.Name = "btnMostrarParrafo3";
            this.btnMostrarParrafo3.Size = new System.Drawing.Size(129, 44);
            this.btnMostrarParrafo3.TabIndex = 8;
            this.btnMostrarParrafo3.Text = "Mostrar Parrafo";
            this.btnMostrarParrafo3.UseVisualStyleBackColor = true;
            this.btnMostrarParrafo3.Click += new System.EventHandler(this.btnMostrarParrafo3_Click);
            // 
            // lbParrafo3
            // 
            this.lbParrafo3.FormattingEnabled = true;
            this.lbParrafo3.ItemHeight = 20;
            this.lbParrafo3.Location = new System.Drawing.Point(349, 26);
            this.lbParrafo3.Name = "lbParrafo3";
            this.lbParrafo3.Size = new System.Drawing.Size(279, 304);
            this.lbParrafo3.TabIndex = 6;
            // 
            // btnBuscarTexto3
            // 
            this.btnBuscarTexto3.Location = new System.Drawing.Point(42, 188);
            this.btnBuscarTexto3.Name = "btnBuscarTexto3";
            this.btnBuscarTexto3.Size = new System.Drawing.Size(111, 44);
            this.btnBuscarTexto3.TabIndex = 4;
            this.btnBuscarTexto3.Text = "Buscar Texto";
            this.btnBuscarTexto3.UseVisualStyleBackColor = true;
            this.btnBuscarTexto3.Click += new System.EventHandler(this.btnBuscarTexto3_Click);
            // 
            // tbPalabra3
            // 
            this.tbPalabra3.Location = new System.Drawing.Point(43, 144);
            this.tbPalabra3.Name = "tbPalabra3";
            this.tbPalabra3.Size = new System.Drawing.Size(237, 26);
            this.tbPalabra3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Buscar palabra";
            // 
            // tbParrafo3
            // 
            this.tbParrafo3.Location = new System.Drawing.Point(42, 58);
            this.tbParrafo3.Multiline = true;
            this.tbParrafo3.Name = "tbParrafo3";
            this.tbParrafo3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbParrafo3.Size = new System.Drawing.Size(237, 30);
            this.tbParrafo3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ingresar Parrafo";
            // 
            // tb4
            // 
            this.tb4.Controls.Add(this.btnBuscarPorNombre4);
            this.tb4.Controls.Add(this.btnBuscarPorID4);
            this.tb4.Controls.Add(this.btnGenerarEstudiantes);
            this.tb4.Controls.Add(this.tbNombre4);
            this.tb4.Controls.Add(this.label7);
            this.tb4.Controls.Add(this.tbID4);
            this.tb4.Controls.Add(this.lbl);
            this.tb4.Controls.Add(this.label6);
            this.tb4.Controls.Add(this.lbEstudiantes4);
            this.tb4.Location = new System.Drawing.Point(4, 29);
            this.tb4.Name = "tb4";
            this.tb4.Padding = new System.Windows.Forms.Padding(3);
            this.tb4.Size = new System.Drawing.Size(693, 354);
            this.tb4.TabIndex = 3;
            this.tb4.Text = "Ejercicio4";
            this.tb4.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPorNombre4
            // 
            this.btnBuscarPorNombre4.Location = new System.Drawing.Point(149, 221);
            this.btnBuscarPorNombre4.Name = "btnBuscarPorNombre4";
            this.btnBuscarPorNombre4.Size = new System.Drawing.Size(109, 61);
            this.btnBuscarPorNombre4.TabIndex = 8;
            this.btnBuscarPorNombre4.Text = "Buscar Nombre";
            this.btnBuscarPorNombre4.UseVisualStyleBackColor = true;
            this.btnBuscarPorNombre4.Click += new System.EventHandler(this.btnBuscarPorNombre4_Click);
            // 
            // btnBuscarPorID4
            // 
            this.btnBuscarPorID4.Location = new System.Drawing.Point(32, 221);
            this.btnBuscarPorID4.Name = "btnBuscarPorID4";
            this.btnBuscarPorID4.Size = new System.Drawing.Size(102, 50);
            this.btnBuscarPorID4.TabIndex = 7;
            this.btnBuscarPorID4.Text = "Buscar ID";
            this.btnBuscarPorID4.UseVisualStyleBackColor = true;
            this.btnBuscarPorID4.Click += new System.EventHandler(this.btnBuscarPorID4_Click);
            // 
            // btnGenerarEstudiantes
            // 
            this.btnGenerarEstudiantes.Location = new System.Drawing.Point(336, 85);
            this.btnGenerarEstudiantes.Name = "btnGenerarEstudiantes";
            this.btnGenerarEstudiantes.Size = new System.Drawing.Size(91, 50);
            this.btnGenerarEstudiantes.TabIndex = 6;
            this.btnGenerarEstudiantes.Text = "Generar Estudiantes";
            this.btnGenerarEstudiantes.UseVisualStyleBackColor = true;
            this.btnGenerarEstudiantes.Click += new System.EventHandler(this.btnGenerarEstudiantes_Click);
            // 
            // tbNombre4
            // 
            this.tbNombre4.Location = new System.Drawing.Point(32, 168);
            this.tbNombre4.Name = "tbNombre4";
            this.tbNombre4.Size = new System.Drawing.Size(176, 26);
            this.tbNombre4.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nombre";
            // 
            // tbID4
            // 
            this.tbID4.Location = new System.Drawing.Point(32, 85);
            this.tbID4.Name = "tbID4";
            this.tbID4.Size = new System.Drawing.Size(176, 26);
            this.tbID4.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(27, 53);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(38, 29);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lista de estudiantes";
            // 
            // lbEstudiantes4
            // 
            this.lbEstudiantes4.FormattingEnabled = true;
            this.lbEstudiantes4.ItemHeight = 20;
            this.lbEstudiantes4.Location = new System.Drawing.Point(450, 85);
            this.lbEstudiantes4.Name = "lbEstudiantes4";
            this.lbEstudiantes4.Size = new System.Drawing.Size(211, 244);
            this.lbEstudiantes4.TabIndex = 0;
            // 
            // tb5
            // 
            this.tb5.Controls.Add(this.btnBuscarMazMin5);
            this.tb5.Controls.Add(this.btnGenerarLista5);
            this.tb5.Controls.Add(this.lbLista5);
            this.tb5.Location = new System.Drawing.Point(4, 29);
            this.tb5.Name = "tb5";
            this.tb5.Padding = new System.Windows.Forms.Padding(3);
            this.tb5.Size = new System.Drawing.Size(693, 354);
            this.tb5.TabIndex = 4;
            this.tb5.Text = "Ejercicio5";
            this.tb5.UseVisualStyleBackColor = true;
            // 
            // tb6
            // 
            this.tb6.Controls.Add(this.label8);
            this.tb6.Controls.Add(this.btnBuscarMatriz6);
            this.tb6.Controls.Add(this.btnGenerarMatriz6);
            this.tb6.Controls.Add(this.tbNumero6);
            this.tb6.Controls.Add(this.dgMatriz6);
            this.tb6.Location = new System.Drawing.Point(4, 29);
            this.tb6.Name = "tb6";
            this.tb6.Padding = new System.Windows.Forms.Padding(3);
            this.tb6.Size = new System.Drawing.Size(693, 354);
            this.tb6.TabIndex = 5;
            this.tb6.Text = "Ejercicio6";
            this.tb6.UseVisualStyleBackColor = true;
            // 
            // lbLista5
            // 
            this.lbLista5.FormattingEnabled = true;
            this.lbLista5.ItemHeight = 20;
            this.lbLista5.Location = new System.Drawing.Point(282, 36);
            this.lbLista5.Name = "lbLista5";
            this.lbLista5.Size = new System.Drawing.Size(359, 284);
            this.lbLista5.TabIndex = 0;
            // 
            // btnGenerarLista5
            // 
            this.btnGenerarLista5.Location = new System.Drawing.Point(35, 61);
            this.btnGenerarLista5.Name = "btnGenerarLista5";
            this.btnGenerarLista5.Size = new System.Drawing.Size(138, 70);
            this.btnGenerarLista5.TabIndex = 1;
            this.btnGenerarLista5.Text = "Generar Lista";
            this.btnGenerarLista5.UseVisualStyleBackColor = true;
            this.btnGenerarLista5.Click += new System.EventHandler(this.btnGenerarLista5_Click);
            // 
            // btnBuscarMazMin5
            // 
            this.btnBuscarMazMin5.Location = new System.Drawing.Point(35, 203);
            this.btnBuscarMazMin5.Name = "btnBuscarMazMin5";
            this.btnBuscarMazMin5.Size = new System.Drawing.Size(138, 70);
            this.btnBuscarMazMin5.TabIndex = 2;
            this.btnBuscarMazMin5.Text = "Buscar Max/Min";
            this.btnBuscarMazMin5.UseVisualStyleBackColor = true;
            this.btnBuscarMazMin5.Click += new System.EventHandler(this.btnBuscarMazMin5_Click);
            // 
            // dgMatriz6
            // 
            this.dgMatriz6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatriz6.Location = new System.Drawing.Point(311, 48);
            this.dgMatriz6.Name = "dgMatriz6";
            this.dgMatriz6.RowHeadersWidth = 62;
            this.dgMatriz6.RowTemplate.Height = 28;
            this.dgMatriz6.Size = new System.Drawing.Size(345, 272);
            this.dgMatriz6.TabIndex = 0;
            // 
            // tbNumero6
            // 
            this.tbNumero6.Location = new System.Drawing.Point(14, 90);
            this.tbNumero6.Name = "tbNumero6";
            this.tbNumero6.Size = new System.Drawing.Size(241, 26);
            this.tbNumero6.TabIndex = 1;
            // 
            // btnGenerarMatriz6
            // 
            this.btnGenerarMatriz6.Location = new System.Drawing.Point(16, 161);
            this.btnGenerarMatriz6.Name = "btnGenerarMatriz6";
            this.btnGenerarMatriz6.Size = new System.Drawing.Size(94, 74);
            this.btnGenerarMatriz6.TabIndex = 2;
            this.btnGenerarMatriz6.Text = "Generar Matriz";
            this.btnGenerarMatriz6.UseVisualStyleBackColor = true;
            this.btnGenerarMatriz6.Click += new System.EventHandler(this.btnGenerarMatriz6_Click);
            // 
            // btnBuscarMatriz6
            // 
            this.btnBuscarMatriz6.Location = new System.Drawing.Point(161, 161);
            this.btnBuscarMatriz6.Name = "btnBuscarMatriz6";
            this.btnBuscarMatriz6.Size = new System.Drawing.Size(94, 74);
            this.btnBuscarMatriz6.TabIndex = 3;
            this.btnBuscarMatriz6.Text = "Buscar Matriz";
            this.btnBuscarMatriz6.UseVisualStyleBackColor = true;
            this.btnBuscarMatriz6.Click += new System.EventHandler(this.btnBuscarMatriz6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ingrese numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ejercicio2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Ejercicio2.ResumeLayout(false);
            this.tb1.ResumeLayout(false);
            this.tb1.PerformLayout();
            this.tb2.ResumeLayout(false);
            this.tb2.PerformLayout();
            this.tb3.ResumeLayout(false);
            this.tb3.PerformLayout();
            this.tb4.ResumeLayout(false);
            this.tb4.PerformLayout();
            this.tb5.ResumeLayout(false);
            this.tb6.ResumeLayout(false);
            this.tb6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Ejercicio2;
        private System.Windows.Forms.TabPage tb1;
        private System.Windows.Forms.TabPage tb2;
        private System.Windows.Forms.TabPage tb3;
        private System.Windows.Forms.TabPage tb4;
        private System.Windows.Forms.TabPage tb5;
        private System.Windows.Forms.TabPage tb6;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.TextBox tbBuscar2;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ListBox lbNumeros2;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Button btnGenerar2;
        private System.Windows.Forms.Button btnOrdenar2;
        private System.Windows.Forms.TextBox tbParrafo3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPalabra3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarTexto3;
        private System.Windows.Forms.ListBox lbParrafo3;
        private System.Windows.Forms.Button btnMostrarParrafo3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbEstudiantes4;
        private System.Windows.Forms.Button btnBuscarPorNombre4;
        private System.Windows.Forms.Button btnBuscarPorID4;
        private System.Windows.Forms.Button btnGenerarEstudiantes;
        private System.Windows.Forms.TextBox tbNombre4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbID4;
        private System.Windows.Forms.Button btnBuscarMazMin5;
        private System.Windows.Forms.Button btnGenerarLista5;
        private System.Windows.Forms.ListBox lbLista5;
        private System.Windows.Forms.DataGridView dgMatriz6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarMatriz6;
        private System.Windows.Forms.Button btnGenerarMatriz6;
        private System.Windows.Forms.TextBox tbNumero6;
    }
}

