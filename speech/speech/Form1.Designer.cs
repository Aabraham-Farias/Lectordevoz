namespace speech
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Leer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pausar = new System.Windows.Forms.Button();
            this.Detener = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(111, 224);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(376, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 25;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(485, 126);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(376, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Leer
            // 
            this.Leer.Location = new System.Drawing.Point(614, 21);
            this.Leer.Name = "Leer";
            this.Leer.Size = new System.Drawing.Size(75, 47);
            this.Leer.TabIndex = 3;
            this.Leer.Text = "Leer";
            this.Leer.UseVisualStyleBackColor = true;
            this.Leer.Click += new System.EventHandler(this.Leer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Voz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pausar
            // 
            this.Pausar.Location = new System.Drawing.Point(614, 74);
            this.Pausar.Name = "Pausar";
            this.Pausar.Size = new System.Drawing.Size(75, 47);
            this.Pausar.TabIndex = 5;
            this.Pausar.Text = "Pausar";
            this.Pausar.UseVisualStyleBackColor = true;
            this.Pausar.Click += new System.EventHandler(this.Pausar_Click);
            // 
            // Detener
            // 
            this.Detener.Location = new System.Drawing.Point(614, 127);
            this.Detener.Name = "Detener";
            this.Detener.Size = new System.Drawing.Size(75, 47);
            this.Detener.TabIndex = 6;
            this.Detener.Text = "Detener";
            this.Detener.UseVisualStyleBackColor = true;
            this.Detener.Click += new System.EventHandler(this.Detener_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(614, 180);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 47);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(614, 233);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 47);
            this.Salir.TabIndex = 8;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(614, 286);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 47);
            this.Agregar.TabIndex = 9;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(111, 288);
            this.trackBar2.Minimum = -10;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(376, 45);
            this.trackBar2.TabIndex = 10;
            this.trackBar2.TickFrequency = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Volumen";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Velocidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 356);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Detener);
            this.Controls.Add(this.Pausar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Leer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Leer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pausar;
        private System.Windows.Forms.Button Detener;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

