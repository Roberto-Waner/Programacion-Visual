using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Is1 = Is2 = false;
        }

        public double num1, num2, resultado;
        public bool Is1, Is2, es_op;
        int operacion;

        private void bt_1_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("1");
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("2");
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("3");
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("4");
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("5");
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("6");
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("7");
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("8");
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("9");
        }

        private void bt_c_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
        }

        private void bt_sumar_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                num1 = obtener_valor();
                Is1 = true;
                operacion = 0;
            }
        }

        private void bt_restar_Click(object sender, EventArgs e)
        {
            num1 = obtener_valor();
            Is1 = true;
            operacion = 0;
        }

        private void bt_multiplicar_Click(object sender, EventArgs e)
        {
            num1 = obtener_valor();
            Is1 = true;
            operacion = 0;
        }

        private void bt_dividir_Click(object sender, EventArgs e)
        {
            num1 = obtener_valor();
            Is1 |= true;
            operacion = 0;
        }

        private void bt_igual_Click(object sender, EventArgs e)
        {
            try
            {
                if(operacion == 0)
                {
                    if (Is1)
                    {
                        num2 = obtener_valor();
                        actualizar_pantalla(operar(num1, num2, "+").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Esta operacion requiere dos operados");
            }
        }

        public void limpiar_pantalla()
        {
            pantalla.Text = "";
        }

        public double obtener_valor()
        {
            double valor = Convert.ToDouble(pantalla.Text);
            limpiar_pantalla();
            return valor;
        }

        public void actualizar_pantalla(string texto)
        {
            pantalla.Text += texto;
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("0");
        }


        

    }
}
