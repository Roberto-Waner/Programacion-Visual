namespace PARTE_3_Tomas_de_decisiones__If_Then_Else_
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Empresa = new System.Windows.Forms.TextBox();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Tiempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdb_Interes1 = new System.Windows.Forms.RadioButton();
            this.rdb_Interes2 = new System.Windows.Forms.RadioButton();
            this.rdb_Interes3 = new System.Windows.Forms.RadioButton();
            this.txt_TasaInterEX = new System.Windows.Forms.TextBox();
            this.lst_Resul = new System.Windows.Forms.ListBox();
            this.btn_Analisis = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_Fin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Empresa:";
            // 
            // txt_Empresa
            // 
            this.txt_Empresa.Location = new System.Drawing.Point(164, 20);
            this.txt_Empresa.Name = "txt_Empresa";
            this.txt_Empresa.Size = new System.Drawing.Size(402, 22);
            this.txt_Empresa.TabIndex = 1;
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(92, 66);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(124, 22);
            this.txt_Monto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto prestamo ($)";
            // 
            // txt_Tiempo
            // 
            this.txt_Tiempo.Location = new System.Drawing.Point(449, 69);
            this.txt_Tiempo.Name = "txt_Tiempo";
            this.txt_Tiempo.Size = new System.Drawing.Size(117, 22);
            this.txt_Tiempo.TabIndex = 5;
            this.txt_Tiempo.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiempo (años)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tasa Interes:";
            // 
            // rdb_Interes1
            // 
            this.rdb_Interes1.AutoSize = true;
            this.rdb_Interes1.Checked = true;
            this.rdb_Interes1.Location = new System.Drawing.Point(25, 211);
            this.rdb_Interes1.Name = "rdb_Interes1";
            this.rdb_Interes1.Size = new System.Drawing.Size(57, 20);
            this.rdb_Interes1.TabIndex = 7;
            this.rdb_Interes1.TabStop = true;
            this.rdb_Interes1.Text = "12 %";
            this.rdb_Interes1.UseVisualStyleBackColor = true;
            // 
            // rdb_Interes2
            // 
            this.rdb_Interes2.AutoSize = true;
            this.rdb_Interes2.Location = new System.Drawing.Point(156, 211);
            this.rdb_Interes2.Name = "rdb_Interes2";
            this.rdb_Interes2.Size = new System.Drawing.Size(67, 20);
            this.rdb_Interes2.TabIndex = 8;
            this.rdb_Interes2.TabStop = true;
            this.rdb_Interes2.Text = "23.5 %";
            this.rdb_Interes2.UseVisualStyleBackColor = true;
            // 
            // rdb_Interes3
            // 
            this.rdb_Interes3.AutoSize = true;
            this.rdb_Interes3.Location = new System.Drawing.Point(294, 211);
            this.rdb_Interes3.Name = "rdb_Interes3";
            this.rdb_Interes3.Size = new System.Drawing.Size(106, 20);
            this.rdb_Interes3.TabIndex = 9;
            this.rdb_Interes3.TabStop = true;
            this.rdb_Interes3.Text = "Otro, indique:";
            this.rdb_Interes3.UseVisualStyleBackColor = true;
            // 
            // txt_TasaInterEX
            // 
            this.txt_TasaInterEX.Enabled = false;
            this.txt_TasaInterEX.Location = new System.Drawing.Point(413, 209);
            this.txt_TasaInterEX.Name = "txt_TasaInterEX";
            this.txt_TasaInterEX.Size = new System.Drawing.Size(153, 22);
            this.txt_TasaInterEX.TabIndex = 10;
            this.txt_TasaInterEX.Text = "0";
            // 
            // lst_Resul
            // 
            this.lst_Resul.Enabled = false;
            this.lst_Resul.FormattingEnabled = true;
            this.lst_Resul.ItemHeight = 16;
            this.lst_Resul.Location = new System.Drawing.Point(25, 265);
            this.lst_Resul.Name = "lst_Resul";
            this.lst_Resul.Size = new System.Drawing.Size(550, 132);
            this.lst_Resul.TabIndex = 11;
            // 
            // btn_Analisis
            // 
            this.btn_Analisis.Location = new System.Drawing.Point(90, 442);
            this.btn_Analisis.Name = "btn_Analisis";
            this.btn_Analisis.Size = new System.Drawing.Size(110, 50);
            this.btn_Analisis.TabIndex = 12;
            this.btn_Analisis.Text = "Análisis \r\nFinanciero";
            this.btn_Analisis.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(238, 442);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(110, 50);
            this.btn_guardar.TabIndex = 13;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Fin
            // 
            this.btn_Fin.Location = new System.Drawing.Point(388, 442);
            this.btn_Fin.Name = "btn_Fin";
            this.btn_Fin.Size = new System.Drawing.Size(110, 50);
            this.btn_Fin.TabIndex = 14;
            this.btn_Fin.Text = "Salir del \r\nprograma";
            this.btn_Fin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 521);
            this.Controls.Add(this.btn_Fin);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_Analisis);
            this.Controls.Add(this.lst_Resul);
            this.Controls.Add(this.txt_TasaInterEX);
            this.Controls.Add(this.rdb_Interes3);
            this.Controls.Add(this.rdb_Interes2);
            this.Controls.Add(this.rdb_Interes1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Tiempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Empresa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Empresa;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Tiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdb_Interes1;
        private System.Windows.Forms.RadioButton rdb_Interes2;
        private System.Windows.Forms.RadioButton rdb_Interes3;
        private System.Windows.Forms.TextBox txt_TasaInterEX;
        private System.Windows.Forms.ListBox lst_Resul;
        private System.Windows.Forms.Button btn_Analisis;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_Fin;
    }
}

