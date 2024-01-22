namespace Prueva_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cb_op = new ComboBox();
            txt_nu2 = new TextBox();
            txt_resultado = new TextBox();
            bt_calcular = new Button();
            txt_nu1 = new TextBox();
            bt_nuevo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 31);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Operando1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 72);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Operacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 118);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Operando3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 160);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Resultados";
            // 
            // cb_op
            // 
            cb_op.FormattingEnabled = true;
            cb_op.Items.AddRange(new object[] { "Suma", "Resta", "Multiplicacion", "Division", "Raiz", "Potencia" });
            cb_op.Location = new Point(133, 69);
            cb_op.Name = "cb_op";
            cb_op.Size = new Size(121, 23);
            cb_op.TabIndex = 5;
            // 
            // txt_nu2
            // 
            txt_nu2.Location = new Point(133, 115);
            txt_nu2.Name = "txt_nu2";
            txt_nu2.Size = new Size(121, 23);
            txt_nu2.TabIndex = 6;
            // 
            // txt_resultado
            // 
            txt_resultado.Enabled = false;
            txt_resultado.Location = new Point(133, 157);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.Size = new Size(121, 23);
            txt_resultado.TabIndex = 7;
            // 
            // bt_calcular
            // 
            bt_calcular.Location = new Point(312, 27);
            bt_calcular.Name = "bt_calcular";
            bt_calcular.Size = new Size(75, 23);
            bt_calcular.TabIndex = 8;
            bt_calcular.Text = "Calcular";
            bt_calcular.UseVisualStyleBackColor = true;
            bt_calcular.Click += bt_calcular_Click;
            // 
            // txt_nu1
            // 
            txt_nu1.Location = new Point(133, 28);
            txt_nu1.Name = "txt_nu1";
            txt_nu1.Size = new Size(121, 23);
            txt_nu1.TabIndex = 9;
            // 
            // bt_nuevo
            // 
            bt_nuevo.Location = new Point(312, 72);
            bt_nuevo.Name = "bt_nuevo";
            bt_nuevo.Size = new Size(75, 23);
            bt_nuevo.TabIndex = 10;
            bt_nuevo.Text = "Nuevo";
            bt_nuevo.UseVisualStyleBackColor = true;
            bt_nuevo.Click += bt_nuevo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 208);
            Controls.Add(bt_nuevo);
            Controls.Add(txt_nu1);
            Controls.Add(bt_calcular);
            Controls.Add(txt_resultado);
            Controls.Add(txt_nu2);
            Controls.Add(cb_op);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cb_op;
        private TextBox txt_nu2;
        private TextBox txt_resultado;
        private Button bt_calcular;
        private TextBox txt_nu1;
        private Button bt_nuevo;
    }
}