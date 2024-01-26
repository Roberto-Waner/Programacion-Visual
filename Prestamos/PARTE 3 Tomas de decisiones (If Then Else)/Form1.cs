using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARTE_3_Tomas_de_decisiones__If_Then_Else_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double tasal;
        int Tiempo;

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void rdb_Interes3_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_Interes3.Checked == true)
            {
                txt_TasaInterEX.Enabled = true;
                txt_TasaInterEX.Focus();
            }
            else
            {
                txt_TasaInterEX.Text = "0";
                txt_TasaInterEX.Enabled = false;
            }
        }

        private void rdb_Interes1_Click(object sender, EventArgs e)
        {
            tasal = 0.12;
        }

        private void rdb_Interes2_Click(object sender, EventArgs e)
        {
            tasal = 0.235;
        }

        private void btn_Fin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Analisis_Click(object sender, EventArgs e)
        {
            string Nom_Empresa;
            double MontoInic = 0, MontoFin = 0;
            
            Nom_Empresa = txt_Empresa.Text;
            Nom_Empresa = Nom_Empresa.Trim();

            if(Nom_Empresa.Length == 0)
            {
                MessageBox.Show("Bebe indicar Nombre de la empresa", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_Monto.Focus();
                return;
            }

            if (!(IsNumeric(txt_Monto.Text)))
            {
                MessageBox.Show("Valor Monto incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Monto.Focus();
                return;
            }
            else
            {
                MontoInic = Convert.ToDouble(txt_Monto.Text);

                if(!(MontoInic > 0))
                {
                    MessageBox.Show("Valor Monto no puede ser negativo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Monto.Focus();
                    return;
                }
            }

            Tiempo = Convert.ToInt32(txt_Tiempo.Text);
            txt_TasaInterEX.Text = txt_TasaInterEX.Text.Trim();

            if(rdb_Interes3.Checked == true)
            {
                if(txt_TasaInterEX.Text.Length > 0)
                {
                    if(!(IsNumeric(txt_TasaInterEX.Text) == true))
                    {
                        MessageBox.Show("Tasa interes incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_TasaInterEX.Text = "0";
                        txt_TasaInterEX.Focus();
                        return;
                    }
                    else
                    {
                        tasal = Convert.ToDouble(txt_TasaInterEX.Text) / 100;
                    }
                }
                else
                {
                    MessageBox.Show("Aun no ha indicado una tasa interes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_TasaInterEX.Focus();
                    return;
                }
            }
            MontoFin = (1 + tasal);
            MontoFin = MontoInic * (Math.Pow(Convert.ToDouble(MontoFin), Tiempo));
            tasal *= 100;

            //Muestra la respuesta Monto a pagar
            lst_Resul.Items.Clear();
            lst_Resul.Items.Add("Empresa: " + txt_Empresa.Text);
            lst_Resul.Items.Add("Monto: $" + MontoInic + ", Tasa anual: " + tasal);
            lst_Resul.Items.Add("Monto a pagar: $" + MontoFin);
        }

        private void btn_general_Click(object sender, EventArgs e)
        {
            Tamortizacion amortizacion = new Tamortizacion();
            AddOwnedForm(amortizacion);
            amortizacion.txt_monto_prest.Text = txt_Monto.Text;
            amortizacion.txt_tasa_interes.Text = (tasal / 100).ToString();
            amortizacion.txt_periodo_anual.Text = Tiempo.ToString();
            amortizacion.Show();
        }
    }
}

