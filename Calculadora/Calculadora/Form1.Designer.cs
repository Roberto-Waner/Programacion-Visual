namespace Calculadora
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
            this.pantalla = new System.Windows.Forms.TextBox();
            this.bt_ce = new System.Windows.Forms.Button();
            this.bt_c = new System.Windows.Forms.Button();
            this.bt_sumar = new System.Windows.Forms.Button();
            this.bt_restar = new System.Windows.Forms.Button();
            this.bt_multiplicar = new System.Windows.Forms.Button();
            this.bt_dividir = new System.Windows.Forms.Button();
            this.bt_log = new System.Windows.Forms.Button();
            this.bt_sen = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_ln = new System.Windows.Forms.Button();
            this.bt_cos = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_igual = new System.Windows.Forms.Button();
            this.bt_tan = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_potencia = new System.Windows.Forms.Button();
            this.bt_punto = new System.Windows.Forms.Button();
            this.bt_0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.Location = new System.Drawing.Point(12, 12);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(313, 98);
            this.pantalla.TabIndex = 0;
            // 
            // bt_ce
            // 
            this.bt_ce.Location = new System.Drawing.Point(12, 133);
            this.bt_ce.Name = "bt_ce";
            this.bt_ce.Size = new System.Drawing.Size(37, 35);
            this.bt_ce.TabIndex = 3;
            this.bt_ce.Text = "CE";
            this.bt_ce.UseVisualStyleBackColor = true;
            // 
            // bt_c
            // 
            this.bt_c.Location = new System.Drawing.Point(68, 133);
            this.bt_c.Name = "bt_c";
            this.bt_c.Size = new System.Drawing.Size(37, 35);
            this.bt_c.TabIndex = 4;
            this.bt_c.Text = "C";
            this.bt_c.UseVisualStyleBackColor = true;
            this.bt_c.Click += new System.EventHandler(this.bt_c_Click);
            // 
            // bt_sumar
            // 
            this.bt_sumar.Location = new System.Drawing.Point(123, 133);
            this.bt_sumar.Name = "bt_sumar";
            this.bt_sumar.Size = new System.Drawing.Size(37, 35);
            this.bt_sumar.TabIndex = 5;
            this.bt_sumar.Text = "+";
            this.bt_sumar.UseVisualStyleBackColor = true;
            this.bt_sumar.Click += new System.EventHandler(this.bt_sumar_Click);
            // 
            // bt_restar
            // 
            this.bt_restar.Location = new System.Drawing.Point(179, 133);
            this.bt_restar.Name = "bt_restar";
            this.bt_restar.Size = new System.Drawing.Size(37, 35);
            this.bt_restar.TabIndex = 6;
            this.bt_restar.Text = "-";
            this.bt_restar.UseVisualStyleBackColor = true;
            this.bt_restar.Click += new System.EventHandler(this.bt_restar_Click);
            // 
            // bt_multiplicar
            // 
            this.bt_multiplicar.Location = new System.Drawing.Point(233, 133);
            this.bt_multiplicar.Name = "bt_multiplicar";
            this.bt_multiplicar.Size = new System.Drawing.Size(37, 35);
            this.bt_multiplicar.TabIndex = 7;
            this.bt_multiplicar.Text = "*";
            this.bt_multiplicar.UseVisualStyleBackColor = true;
            this.bt_multiplicar.Click += new System.EventHandler(this.bt_multiplicar_Click);
            // 
            // bt_dividir
            // 
            this.bt_dividir.Location = new System.Drawing.Point(288, 133);
            this.bt_dividir.Name = "bt_dividir";
            this.bt_dividir.Size = new System.Drawing.Size(37, 35);
            this.bt_dividir.TabIndex = 8;
            this.bt_dividir.Text = "/";
            this.bt_dividir.UseVisualStyleBackColor = true;
            this.bt_dividir.Click += new System.EventHandler(this.bt_dividir_Click);
            // 
            // bt_log
            // 
            this.bt_log.Location = new System.Drawing.Point(252, 174);
            this.bt_log.Name = "bt_log";
            this.bt_log.Size = new System.Drawing.Size(73, 35);
            this.bt_log.TabIndex = 13;
            this.bt_log.Text = "Log";
            this.bt_log.UseVisualStyleBackColor = true;
            // 
            // bt_sen
            // 
            this.bt_sen.Location = new System.Drawing.Point(179, 174);
            this.bt_sen.Name = "bt_sen";
            this.bt_sen.Size = new System.Drawing.Size(67, 35);
            this.bt_sen.TabIndex = 12;
            this.bt_sen.Text = "Sen";
            this.bt_sen.UseVisualStyleBackColor = true;
            // 
            // bt_9
            // 
            this.bt_9.Location = new System.Drawing.Point(123, 174);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(37, 35);
            this.bt_9.TabIndex = 11;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = true;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // bt_8
            // 
            this.bt_8.Location = new System.Drawing.Point(68, 174);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(37, 35);
            this.bt_8.TabIndex = 10;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = true;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // bt_7
            // 
            this.bt_7.Location = new System.Drawing.Point(12, 174);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(37, 35);
            this.bt_7.TabIndex = 9;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = true;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_ln
            // 
            this.bt_ln.Location = new System.Drawing.Point(252, 215);
            this.bt_ln.Name = "bt_ln";
            this.bt_ln.Size = new System.Drawing.Size(73, 35);
            this.bt_ln.TabIndex = 18;
            this.bt_ln.Text = "Ln";
            this.bt_ln.UseVisualStyleBackColor = true;
            // 
            // bt_cos
            // 
            this.bt_cos.Location = new System.Drawing.Point(179, 215);
            this.bt_cos.Name = "bt_cos";
            this.bt_cos.Size = new System.Drawing.Size(67, 35);
            this.bt_cos.TabIndex = 17;
            this.bt_cos.Text = "Cos";
            this.bt_cos.UseVisualStyleBackColor = true;
            // 
            // bt_6
            // 
            this.bt_6.Location = new System.Drawing.Point(123, 215);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(37, 35);
            this.bt_6.TabIndex = 16;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = true;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_5
            // 
            this.bt_5.Location = new System.Drawing.Point(68, 215);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(37, 35);
            this.bt_5.TabIndex = 15;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = true;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(12, 215);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(37, 35);
            this.bt_4.TabIndex = 14;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_igual
            // 
            this.bt_igual.Location = new System.Drawing.Point(252, 256);
            this.bt_igual.Name = "bt_igual";
            this.bt_igual.Size = new System.Drawing.Size(73, 76);
            this.bt_igual.TabIndex = 23;
            this.bt_igual.Text = "=";
            this.bt_igual.UseVisualStyleBackColor = true;
            this.bt_igual.Click += new System.EventHandler(this.bt_igual_Click);
            // 
            // bt_tan
            // 
            this.bt_tan.Location = new System.Drawing.Point(179, 256);
            this.bt_tan.Name = "bt_tan";
            this.bt_tan.Size = new System.Drawing.Size(67, 35);
            this.bt_tan.TabIndex = 22;
            this.bt_tan.Text = " tan";
            this.bt_tan.UseVisualStyleBackColor = true;
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(123, 256);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(37, 35);
            this.bt_3.TabIndex = 21;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(68, 256);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(37, 35);
            this.bt_2.TabIndex = 20;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(12, 256);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(37, 35);
            this.bt_1.TabIndex = 19;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_potencia
            // 
            this.bt_potencia.Location = new System.Drawing.Point(179, 297);
            this.bt_potencia.Name = "bt_potencia";
            this.bt_potencia.Size = new System.Drawing.Size(67, 35);
            this.bt_potencia.TabIndex = 26;
            this.bt_potencia.Text = "x*n";
            this.bt_potencia.UseVisualStyleBackColor = true;
            // 
            // bt_punto
            // 
            this.bt_punto.Location = new System.Drawing.Point(123, 297);
            this.bt_punto.Name = "bt_punto";
            this.bt_punto.Size = new System.Drawing.Size(37, 35);
            this.bt_punto.TabIndex = 25;
            this.bt_punto.Text = ".";
            this.bt_punto.UseVisualStyleBackColor = true;
            // 
            // bt_0
            // 
            this.bt_0.Location = new System.Drawing.Point(12, 297);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(93, 35);
            this.bt_0.TabIndex = 24;
            this.bt_0.Text = "0";
            this.bt_0.UseVisualStyleBackColor = true;
            this.bt_0.Click += new System.EventHandler(this.bt_0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 352);
            this.Controls.Add(this.bt_potencia);
            this.Controls.Add(this.bt_punto);
            this.Controls.Add(this.bt_0);
            this.Controls.Add(this.bt_igual);
            this.Controls.Add(this.bt_tan);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.bt_ln);
            this.Controls.Add(this.bt_cos);
            this.Controls.Add(this.bt_6);
            this.Controls.Add(this.bt_5);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_log);
            this.Controls.Add(this.bt_sen);
            this.Controls.Add(this.bt_9);
            this.Controls.Add(this.bt_8);
            this.Controls.Add(this.bt_7);
            this.Controls.Add(this.bt_dividir);
            this.Controls.Add(this.bt_multiplicar);
            this.Controls.Add(this.bt_restar);
            this.Controls.Add(this.bt_sumar);
            this.Controls.Add(this.bt_c);
            this.Controls.Add(this.bt_ce);
            this.Controls.Add(this.pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button bt_ce;
        private System.Windows.Forms.Button bt_c;
        private System.Windows.Forms.Button bt_sumar;
        private System.Windows.Forms.Button bt_restar;
        private System.Windows.Forms.Button bt_multiplicar;
        private System.Windows.Forms.Button bt_dividir;
        private System.Windows.Forms.Button bt_log;
        private System.Windows.Forms.Button bt_sen;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_ln;
        private System.Windows.Forms.Button bt_cos;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_igual;
        private System.Windows.Forms.Button bt_tan;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_potencia;
        private System.Windows.Forms.Button bt_punto;
        private System.Windows.Forms.Button bt_0;
    }
}

