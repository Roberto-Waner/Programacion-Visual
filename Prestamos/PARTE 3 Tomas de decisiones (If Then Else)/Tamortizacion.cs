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
    public partial class Tamortizacion : Form
    {
        public Tamortizacion()
        {
            InitializeComponent();
        }

        private double contentiva(double prestamo, double tasaInteres, int plazo)
        {
            double cuotaMensual = prestamo * (tasaInteres / 12) * Math.Pow(1 + (tasaInteres / 12), plazo * 12) / (Math.Pow(1 + (tasaInteres / 12), plazo * 12) - 1);
            return cuotaMensual;
        }

        private double interesFijo(double prestamo, double tasaInteres, int plazo)
        {
            double interes = prestamo * tasaInteres;
            double pago = (prestamo / (plazo * 12)) + interes;
            return pago;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            double wPrestamo = double.Parse(txt_monto_prest.Text);
            double wTasaInt = double.Parse(txt_tasa_interes.Text);
            int wPlazo = int.Parse(txt_periodo_anual.Text);

            double cuotaMensual = contentiva(wPrestamo, wTasaInt, wPlazo);

            txt_cuota_mensual.Text = string.Format("RD{0:C}", cuotaMensual);
            txt_n_meses.Text = string.Format("{0:#}", (wPlazo * 12));
            txt_total_pagado.Text = string.Format("RD{0:C}", (cuotaMensual * wPlazo * 12));
            txt_ganancia.Text = string.Format("RD{0:C}", ((cuotaMensual * wPlazo * 12) - wPrestamo));

            DataTable dt = new DataTable();
            dt.Columns.Add("Mes", typeof(int));
            dt.Columns.Add("Cuota", typeof (string));
            dt.Columns.Add("Interes", typeof(string));
            dt.Columns.Add("Capital", typeof(string));
            dt.Columns.Add("Interes_Pagado", typeof(string));
            dt.Columns.Add("Capital_Pagado", typeof(string));
            dt.Columns.Add("Saldo_Capital", typeof(string));

            double saldo = wPrestamo;

            double interesPagado = 0;
            double capitalPagado = 0;
            for(int mes = 1; mes <= wPlazo*12; mes++)
            {
                double interesMes = wPrestamo * (wTasaInt / 12);
                double capitalMes = wPrestamo / (wPlazo * 12);
                interesPagado += interesMes;
                capitalPagado += capitalMes;
                saldo = saldo - capitalMes;

                cuotaMensual = Math.Round(cuotaMensual, 2);
                interesMes = Math.Round(interesMes, 2);
                capitalMes = Math.Round(capitalMes, 2);
                interesPagado = Math.Round(interesPagado, 2);
                capitalPagado = Math.Round(capitalPagado, 2);
                saldo = Math.Round(saldo, 2);

                dt.Rows.Add(mes, string.Format("RD{0:C}", cuotaMensual), string.Format("RD{0:C}", interesMes), string.Format("RD{0:C}", capitalMes), string.Format("RD{0:C}", interesPagado), string.Format("RD{0:C}", capitalPagado), string.Format("RD{0:C}", saldo));

                dataGridView1.DataSource = dt;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            double wPrestamo = double.Parse(txt_monto_prest.Text);
            double wTasaInt = double.Parse(txt_tasa_interes.Text);
            int wPlazo = int.Parse(txt_periodo_anual.Text);

            double pago = interesFijo(wPrestamo, wTasaInt, wPlazo);
            //MessageBox.Show(cuotaMensual.ToString());

            txt_cuota_mensual.Text = string.Format("RD{0:C}", pago);
            txt_n_meses.Text = string.Format("{0:#}", (wPlazo * 12));
            txt_total_pagado.Text = string.Format("RD{0:C}", (pago * wPlazo * 12));
            txt_ganancia.Text = string.Format("RD{0:C}", ((pago * wPlazo * 12) - wPrestamo));

            DataTable dt = new DataTable();
            dt.Columns.Add("Mes", typeof(int));
            dt.Columns.Add("Cuota", typeof(string));
            dt.Columns.Add("Interes", typeof(string));
            dt.Columns.Add("Capital", typeof(string));
            dt.Columns.Add("Interes_Pagado", typeof(string));
            dt.Columns.Add("Capital_Pagado", typeof(string));
            dt.Columns.Add("Saldo_Capital", typeof(string));

            double saldo = wPrestamo;

            double interesPagado = 0;
            double capitalPagado = 0;
            for (int mes = 1; mes <= wPlazo * 12; mes++)
            {
                double interesMes = wPrestamo * (wTasaInt / 12);
                double capitalMes = wPrestamo / (wPlazo * 12);
                interesPagado += interesMes;
                capitalPagado += capitalMes;
                saldo = saldo - capitalMes;

                pago = Math.Round(pago, 2);
                interesMes = Math.Round(interesMes, 2);
                capitalMes = Math.Round(capitalMes, 2);
                interesPagado = Math.Round(interesPagado, 2);
                capitalPagado = Math.Round(capitalPagado, 2);
                saldo = Math.Round(saldo, 2);

                dt.Rows.Add(mes, string.Format("RD{0:C}", pago), string.Format("RD{0:C}", interesMes), string.Format("RD{0:C}", capitalMes), string.Format("RD{0:C}", interesPagado), string.Format("RD{0:C}", capitalPagado), string.Format("RD{0:C}", saldo));

                dataGridView1.DataSource = dt;
            }
        }

        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cuotaVariable(double prestamo, double tasaInteres, int plazo)
        {

            //return 0;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
