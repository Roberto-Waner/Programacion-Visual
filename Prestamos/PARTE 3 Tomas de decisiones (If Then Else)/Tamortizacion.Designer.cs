namespace PARTE_3_Tomas_de_decisiones__If_Then_Else_
{
    partial class Tamortizacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_periodo_anual = new System.Windows.Forms.TextBox();
            this.txt_tasa_interes = new System.Windows.Forms.TextBox();
            this.txt_monto_prest = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ganancia = new System.Windows.Forms.TextBox();
            this.txt_total_pagado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_n_meses = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cuota_mensual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto Prestado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tasa de interes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periodos Años";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_periodo_anual);
            this.groupBox1.Controls.Add(this.txt_tasa_interes);
            this.groupBox1.Controls.Add(this.txt_monto_prest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(222, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // txt_periodo_anual
            // 
            this.txt_periodo_anual.Enabled = false;
            this.txt_periodo_anual.Location = new System.Drawing.Point(117, 80);
            this.txt_periodo_anual.Name = "txt_periodo_anual";
            this.txt_periodo_anual.Size = new System.Drawing.Size(100, 20);
            this.txt_periodo_anual.TabIndex = 7;
            // 
            // txt_tasa_interes
            // 
            this.txt_tasa_interes.Enabled = false;
            this.txt_tasa_interes.Location = new System.Drawing.Point(117, 51);
            this.txt_tasa_interes.Name = "txt_tasa_interes";
            this.txt_tasa_interes.Size = new System.Drawing.Size(100, 20);
            this.txt_tasa_interes.TabIndex = 6;
            // 
            // txt_monto_prest
            // 
            this.txt_monto_prest.Enabled = false;
            this.txt_monto_prest.Location = new System.Drawing.Point(117, 22);
            this.txt_monto_prest.Name = "txt_monto_prest";
            this.txt_monto_prest.Size = new System.Drawing.Size(100, 20);
            this.txt_monto_prest.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ganancia);
            this.groupBox2.Controls.Add(this.txt_total_pagado);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_n_meses);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_cuota_mensual);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(479, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 129);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salida";
            // 
            // txt_ganancia
            // 
            this.txt_ganancia.Enabled = false;
            this.txt_ganancia.Location = new System.Drawing.Point(155, 95);
            this.txt_ganancia.Name = "txt_ganancia";
            this.txt_ganancia.Size = new System.Drawing.Size(100, 20);
            this.txt_ganancia.TabIndex = 11;
            // 
            // txt_total_pagado
            // 
            this.txt_total_pagado.Enabled = false;
            this.txt_total_pagado.Location = new System.Drawing.Point(155, 69);
            this.txt_total_pagado.Name = "txt_total_pagado";
            this.txt_total_pagado.Size = new System.Drawing.Size(100, 20);
            this.txt_total_pagado.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ganancia para el Banco";
            // 
            // txt_n_meses
            // 
            this.txt_n_meses.Enabled = false;
            this.txt_n_meses.Location = new System.Drawing.Point(155, 43);
            this.txt_n_meses.Name = "txt_n_meses";
            this.txt_n_meses.Size = new System.Drawing.Size(100, 20);
            this.txt_n_meses.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cuota Mensual";
            // 
            // txt_cuota_mensual
            // 
            this.txt_cuota_mensual.Enabled = false;
            this.txt_cuota_mensual.Location = new System.Drawing.Point(155, 18);
            this.txt_cuota_mensual.Name = "txt_cuota_mensual";
            this.txt_cuota_mensual.Size = new System.Drawing.Size(100, 20);
            this.txt_cuota_mensual.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Pagado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "No. Meses a Pagar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 129);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Método de Amortizacion";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 81);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(154, 17);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Capital Fijo (Cuota Variable)";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Interes Fijo (Simple)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(132, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Contentiva (Cuota Fija)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 221);
            this.dataGridView1.TabIndex = 9;
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.Location = new System.Drawing.Point(583, 415);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(75, 23);
            this.bt_imprimir.TabIndex = 10;
            this.bt_imprimir.Text = "Imprimir";
            this.bt_imprimir.UseVisualStyleBackColor = true;
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.Location = new System.Drawing.Point(677, 415);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(75, 23);
            this.bt_cerrar.TabIndex = 12;
            this.bt_cerrar.Text = "Cerrar";
            this.bt_cerrar.UseVisualStyleBackColor = true;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // Tamortizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.bt_cerrar);
            this.Controls.Add(this.bt_imprimir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tamortizacion";
            this.Text = "Tamortizacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_ganancia;
        private System.Windows.Forms.TextBox txt_total_pagado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_n_meses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cuota_mensual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button bt_imprimir;
        private System.Windows.Forms.Button bt_cerrar;
        public System.Windows.Forms.TextBox txt_periodo_anual;
        public System.Windows.Forms.TextBox txt_tasa_interes;
        public System.Windows.Forms.TextBox txt_monto_prest;
    }
}