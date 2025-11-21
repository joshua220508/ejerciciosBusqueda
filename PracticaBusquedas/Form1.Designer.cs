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
            this.tb3 = new System.Windows.Forms.TabPage();
            this.tb4 = new System.Windows.Forms.TabPage();
            this.tb5 = new System.Windows.Forms.TabPage();
            this.tb6 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.NumAleatorios = new System.Windows.Forms.Label();
            this.Ejercicio2.SuspendLayout();
            this.tb1.SuspendLayout();
            this.tb2.SuspendLayout();
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
            this.tb2.Controls.Add(this.NumAleatorios);
            this.tb2.Controls.Add(this.label3);
            this.tb2.Location = new System.Drawing.Point(4, 29);
            this.tb2.Name = "tb2";
            this.tb2.Padding = new System.Windows.Forms.Padding(3);
            this.tb2.Size = new System.Drawing.Size(693, 354);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "Ejercicio2";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(4, 29);
            this.tb3.Name = "tb3";
            this.tb3.Padding = new System.Windows.Forms.Padding(3);
            this.tb3.Size = new System.Drawing.Size(693, 354);
            this.tb3.TabIndex = 2;
            this.tb3.Text = "Ejercicio3";
            this.tb3.UseVisualStyleBackColor = true;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(4, 29);
            this.tb4.Name = "tb4";
            this.tb4.Padding = new System.Windows.Forms.Padding(3);
            this.tb4.Size = new System.Drawing.Size(693, 354);
            this.tb4.TabIndex = 3;
            this.tb4.Text = "Ejercicio4";
            this.tb4.UseVisualStyleBackColor = true;
            // 
            // tb5
            // 
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
            this.tb6.Location = new System.Drawing.Point(4, 29);
            this.tb6.Name = "tb6";
            this.tb6.Padding = new System.Windows.Forms.Padding(3);
            this.tb6.Size = new System.Drawing.Size(693, 354);
            this.tb6.TabIndex = 5;
            this.tb6.Text = "Ejercicio6";
            this.tb6.UseVisualStyleBackColor = true;
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
            // NumAleatorios
            // 
            this.NumAleatorios.AutoSize = true;
            this.NumAleatorios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumAleatorios.Location = new System.Drawing.Point(31, 79);
            this.NumAleatorios.Name = "NumAleatorios";
            this.NumAleatorios.Size = new System.Drawing.Size(179, 22);
            this.NumAleatorios.TabIndex = 1;
            this.NumAleatorios.Text = "                                          ";
            this.NumAleatorios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
        private System.Windows.Forms.Label NumAleatorios;
        private System.Windows.Forms.Label label3;
    }
}

