using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Llamada_y_minutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seg = 0, minutos = 0, seg_restantes = 0, horas = 0;
        double stotal, desc = 0, neto;

        private void bt_cobrar_Click(object sender, EventArgs e)
        {
            bt_iniciar.Enabled = true;
            seg = 0;
            lb_tiempo.Text = "00 : 00 : 00";
            lb_subtotal.Text = "__________";
            lb_descuento.Text = "__________";
            lb_pagar.Text = "__________";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg > 59)
            {
                minutos = (seg / 60);
                seg_restantes = seg % 60;

                horas = minutos / 60;
                minutos = minutos % 60;

                lb_tiempo.Text = string.Format("{0:00} : {1:00} : {2:00}", horas, minutos, seg_restantes);
            }
            else
            {
                lb_tiempo.Text = seg.ToString("00 : 00 : 00");
            }
        }

        private void bt_iniciar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            bt_iniciar.Enabled = false;
            bt_finalizar.Enabled = true;
        }

        private void bt_finalizar_Click(object sender, EventArgs e)
        {
            bt_cobrar.Enabled = true;
            timer1.Stop();
            if (seg > 3)
            {
                minutos += 1;
                minutos += horas * 60;
            }
            if (minutos > 3)
            {
                stotal = (minutos - 3) * 5 + 10;
            }
            else stotal = 10;
            desc = (stotal <= 50) ? stotal * 0.02 :
                (stotal <= 100) ? stotal * 0.25 :
                stotal * 0.03;

            lb_subtotal.Text = stotal.ToString();
            lb_descuento.Text = desc.ToString();
            neto = stotal - desc;
            lb_pagar.Text = neto.ToString();
        }
    }
}
