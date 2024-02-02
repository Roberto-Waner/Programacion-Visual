namespace Publicaciones_Audio_Libro
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
            this.rdbt_Libro = new System.Windows.Forms.RadioButton();
            this.rdbt_audio_libro = new System.Windows.Forms.RadioButton();
            this.btn_capturar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_n_pag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tiempo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_publicar_libro = new System.Windows.Forms.DataGridView();
            this.dgv_publicar_audio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_publicar_libro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_publicar_audio)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbt_Libro
            // 
            this.rdbt_Libro.AutoSize = true;
            this.rdbt_Libro.Location = new System.Drawing.Point(36, 49);
            this.rdbt_Libro.Margin = new System.Windows.Forms.Padding(4);
            this.rdbt_Libro.Name = "rdbt_Libro";
            this.rdbt_Libro.Size = new System.Drawing.Size(110, 20);
            this.rdbt_Libro.TabIndex = 1;
            this.rdbt_Libro.TabStop = true;
            this.rdbt_Libro.Text = "Libro Impreso";
            this.rdbt_Libro.UseVisualStyleBackColor = true;
            this.rdbt_Libro.Click += new System.EventHandler(this.rdbt_Libro_Click);
            // 
            // rdbt_audio_libro
            // 
            this.rdbt_audio_libro.AutoSize = true;
            this.rdbt_audio_libro.Location = new System.Drawing.Point(36, 78);
            this.rdbt_audio_libro.Margin = new System.Windows.Forms.Padding(4);
            this.rdbt_audio_libro.Name = "rdbt_audio_libro";
            this.rdbt_audio_libro.Size = new System.Drawing.Size(96, 20);
            this.rdbt_audio_libro.TabIndex = 2;
            this.rdbt_audio_libro.TabStop = true;
            this.rdbt_audio_libro.Text = "Audio Libro";
            this.rdbt_audio_libro.UseVisualStyleBackColor = true;
            this.rdbt_audio_libro.CheckedChanged += new System.EventHandler(this.rdbt_audio_libro_CheckedChanged);
            // 
            // btn_capturar
            // 
            this.btn_capturar.Location = new System.Drawing.Point(249, 42);
            this.btn_capturar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capturar.Name = "btn_capturar";
            this.btn_capturar.Size = new System.Drawing.Size(160, 28);
            this.btn_capturar.TabIndex = 3;
            this.btn_capturar.Text = "Capturar Datos";
            this.btn_capturar.UseVisualStyleBackColor = true;
            this.btn_capturar.Click += new System.EventHandler(this.btn_capturar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(249, 78);
            this.btn_mostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(160, 28);
            this.btn_mostrar.TabIndex = 4;
            this.btn_mostrar.Text = "Mostrar Datos";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(249, 113);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(160, 28);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Titulo";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Enabled = false;
            this.txt_titulo.Location = new System.Drawing.Point(105, 219);
            this.txt_titulo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(280, 22);
            this.txt_titulo.TabIndex = 8;
            // 
            // txt_precio
            // 
            this.txt_precio.Enabled = false;
            this.txt_precio.Location = new System.Drawing.Point(179, 252);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(104, 22);
            this.txt_precio.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // txt_n_pag
            // 
            this.txt_n_pag.Enabled = false;
            this.txt_n_pag.Location = new System.Drawing.Point(179, 284);
            this.txt_n_pag.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n_pag.Name = "txt_n_pag";
            this.txt_n_pag.Size = new System.Drawing.Size(51, 22);
            this.txt_n_pag.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Num. Paginas";
            // 
            // txt_tiempo
            // 
            this.txt_tiempo.Enabled = false;
            this.txt_tiempo.Location = new System.Drawing.Point(179, 316);
            this.txt_tiempo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tiempo.Name = "txt_tiempo";
            this.txt_tiempo.Size = new System.Drawing.Size(83, 22);
            this.txt_tiempo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tiempo (Minutos)";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(215, 140);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de publicacion";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(16, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(393, 169);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la publicacion";
            // 
            // dgv_publicar_libro
            // 
            this.dgv_publicar_libro.AllowUserToAddRows = false;
            this.dgv_publicar_libro.AllowUserToDeleteRows = false;
            this.dgv_publicar_libro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_publicar_libro.Location = new System.Drawing.Point(433, 42);
            this.dgv_publicar_libro.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_publicar_libro.Name = "dgv_publicar_libro";
            this.dgv_publicar_libro.ReadOnly = true;
            this.dgv_publicar_libro.RowHeadersWidth = 51;
            this.dgv_publicar_libro.Size = new System.Drawing.Size(444, 157);
            this.dgv_publicar_libro.TabIndex = 17;
            this.dgv_publicar_libro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_publicar_libro_CellClick);
//            this.dgv_publicar_libro.SelectionChanged += new System.EventHandler(this.dgv_publicar_libro_SelectionChanged);
            // 
            // dgv_publicar_audio
            // 
            this.dgv_publicar_audio.AllowUserToAddRows = false;
            this.dgv_publicar_audio.AllowUserToDeleteRows = false;
            this.dgv_publicar_audio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_publicar_audio.Location = new System.Drawing.Point(433, 206);
            this.dgv_publicar_audio.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_publicar_audio.Name = "dgv_publicar_audio";
            this.dgv_publicar_audio.ReadOnly = true;
            this.dgv_publicar_audio.RowHeadersWidth = 51;
            this.dgv_publicar_audio.Size = new System.Drawing.Size(444, 157);
            this.dgv_publicar_audio.TabIndex = 18;
            this.dgv_publicar_audio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_publicar_audio_CellClick);
            //this.dgv_publicar_audio.SelectionChanged += new System.EventHandler(this.dgv_publicar_audio_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 377);
            this.Controls.Add(this.dgv_publicar_audio);
            this.Controls.Add(this.dgv_publicar_libro);
            this.Controls.Add(this.txt_tiempo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_n_pag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_capturar);
            this.Controls.Add(this.rdbt_audio_libro);
            this.Controls.Add(this.rdbt_Libro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Publicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_publicar_libro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_publicar_audio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbt_Libro;
        private System.Windows.Forms.RadioButton rdbt_audio_libro;
        private System.Windows.Forms.Button btn_capturar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_n_pag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tiempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_publicar_libro;
        private System.Windows.Forms.DataGridView dgv_publicar_audio;
    }
}

