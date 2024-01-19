namespace Llamada_y_minutos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_tiempo = new System.Windows.Forms.Label();
            this.lb_subtotal = new System.Windows.Forms.Label();
            this.lb_descuento = new System.Windows.Forms.Label();
            this.lb_pagar = new System.Windows.Forms.Label();
            this.bt_iniciar = new System.Windows.Forms.Button();
            this.bt_finalizar = new System.Windows.Forms.Button();
            this.bt_cobrar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subtotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descuento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio a pagar";
            // 
            // lb_tiempo
            // 
            this.lb_tiempo.AutoSize = true;
            this.lb_tiempo.Location = new System.Drawing.Point(197, 65);
            this.lb_tiempo.Name = "lb_tiempo";
            this.lb_tiempo.Size = new System.Drawing.Size(67, 16);
            this.lb_tiempo.TabIndex = 4;
            this.lb_tiempo.Text = "00 : 00 : 00";
            // 
            // lb_subtotal
            // 
            this.lb_subtotal.AutoSize = true;
            this.lb_subtotal.Location = new System.Drawing.Point(197, 108);
            this.lb_subtotal.Name = "lb_subtotal";
            this.lb_subtotal.Size = new System.Drawing.Size(98, 16);
            this.lb_subtotal.TabIndex = 5;
            this.lb_subtotal.Text = "_____________";
            // 
            // lb_descuento
            // 
            this.lb_descuento.AutoSize = true;
            this.lb_descuento.Location = new System.Drawing.Point(197, 161);
            this.lb_descuento.Name = "lb_descuento";
            this.lb_descuento.Size = new System.Drawing.Size(98, 16);
            this.lb_descuento.TabIndex = 6;
            this.lb_descuento.Text = "_____________";
            // 
            // lb_pagar
            // 
            this.lb_pagar.AutoSize = true;
            this.lb_pagar.Location = new System.Drawing.Point(197, 214);
            this.lb_pagar.Name = "lb_pagar";
            this.lb_pagar.Size = new System.Drawing.Size(98, 16);
            this.lb_pagar.TabIndex = 7;
            this.lb_pagar.Text = "_____________";
            // 
            // bt_iniciar
            // 
            this.bt_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_iniciar.Location = new System.Drawing.Point(403, 59);
            this.bt_iniciar.Name = "bt_iniciar";
            this.bt_iniciar.Size = new System.Drawing.Size(100, 53);
            this.bt_iniciar.TabIndex = 8;
            this.bt_iniciar.Text = "Iniciar";
            this.bt_iniciar.UseVisualStyleBackColor = true;
            this.bt_iniciar.Click += new System.EventHandler(this.bt_iniciar_Click);
            // 
            // bt_finalizar
            // 
            this.bt_finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_finalizar.Location = new System.Drawing.Point(403, 118);
            this.bt_finalizar.Name = "bt_finalizar";
            this.bt_finalizar.Size = new System.Drawing.Size(100, 53);
            this.bt_finalizar.TabIndex = 9;
            this.bt_finalizar.Text = "Finalizar";
            this.bt_finalizar.UseVisualStyleBackColor = true;
            this.bt_finalizar.Click += new System.EventHandler(this.bt_finalizar_Click);
            // 
            // bt_cobrar
            // 
            this.bt_cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cobrar.Location = new System.Drawing.Point(403, 177);
            this.bt_cobrar.Name = "bt_cobrar";
            this.bt_cobrar.Size = new System.Drawing.Size(100, 53);
            this.bt_cobrar.TabIndex = 10;
            this.bt_cobrar.Text = "Cobrar";
            this.bt_cobrar.UseVisualStyleBackColor = true;
            this.bt_cobrar.Click += new System.EventHandler(this.bt_cobrar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 366);
            this.Controls.Add(this.bt_cobrar);
            this.Controls.Add(this.bt_finalizar);
            this.Controls.Add(this.bt_iniciar);
            this.Controls.Add(this.lb_pagar);
            this.Controls.Add(this.lb_descuento);
            this.Controls.Add(this.lb_subtotal);
            this.Controls.Add(this.lb_tiempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_tiempo;
        private System.Windows.Forms.Label lb_subtotal;
        private System.Windows.Forms.Label lb_descuento;
        private System.Windows.Forms.Label lb_pagar;
        private System.Windows.Forms.Button bt_iniciar;
        private System.Windows.Forms.Button bt_finalizar;
        private System.Windows.Forms.Button bt_cobrar;
        private System.Windows.Forms.Timer timer1;
    }
}

