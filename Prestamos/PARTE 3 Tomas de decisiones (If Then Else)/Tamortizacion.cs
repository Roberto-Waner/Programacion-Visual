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

        private double contentiva(double prestamo, double tasaInteres, double plazo)
        {
            double cuotaMensual = prestamo * (tasaInteres / 12) * Math.Pow(1 + (tasaInteres / 12), plazo * 12) / (Math.Pow(1 + (tasaInteres / 12), plazo * 12) - 1);
            return cuotaMensual;
        }

        private double interesFijo(double prestamo, double tasaInteres, double plazo)
        {
            double cuotaMensual = (prestamo * (tasaInteres / 12) * (plazo * 12) / (plazo * 12) + (prestamo / (plazo * 12)));
            return cuotaMensual;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            double wPrestamo = double.Parse(txt_monto_prest.Text);
            double wTasaInt = double.Parse(txt_tasa_interes.Text);
            double wPlazo = double.Parse(txt_periodo_anual.Text);

            double cuotaMensual = contentiva(wPrestamo, wTasaInt, wPlazo);

            txt_cuota_mensual.Text = string.Format("{0:C}", cuotaMensual);
            txt_n_meses.Text = string.Format("{0:#}", (wPlazo * 12));
            txt_total_pagado.Text = string.Format("{0:C}", (cuotaMensual * wPlazo * 12));
            txt_ganancia.Text = string.Format("{0:C}", ((cuotaMensual * wPlazo * 12) - wPrestamo));

            DataTable dt = new DataTable();
            dt.Columns.Add("Mes", typeof(int));
            dt.Columns.Add("Cuota", typeof (double));
            dt.Columns.Add("Interes", typeof(double));
            dt.Columns.Add("Capital", typeof(double));
            dt.Columns.Add("Interes_Pagado", typeof(double));
            dt.Columns.Add("Capital_Pagado", typeof(double));
            dt.Columns.Add("Saldo_Capital", typeof(double));

            double saldo = wPrestamo;

            double interesPagado = 0;
            double capitalPagado = 0;
            for(int mes = 1; mes <= wPlazo*12; mes++)
            {
                double interesMes = saldo * wTasaInt / 12;
                double capitalMes = cuotaMensual - interesMes;
                interesPagado += interesMes;
                capitalPagado += capitalMes;
                saldo = saldo - capitalMes;

                cuotaMensual = Math.Round(cuotaMensual, 2);
                interesMes = Math.Round(interesMes, 2);
                capitalMes = Math.Round(capitalMes, 2);
                interesPagado = Math.Round(interesPagado, 2);
                capitalPagado = Math.Round(capitalPagado, 2);
                saldo = Math.Round(saldo, 2);

                dt.Rows.Add(mes, cuotaMensual, interesMes, capitalMes, interesPagado, capitalPagado, saldo);

                dataGridView1.DataSource = dt;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            double wPrestamo = double.Parse(txt_monto_prest.Text);
            double wTasaInt = double.Parse(txt_tasa_interes.Text);
            double wPlazo = double.Parse(txt_periodo_anual.Text);

            double cuotaMensual = interesFijo(wPrestamo, wTasaInt, wPlazo);
            MessageBox.Show(cuotaMensual.ToString());
        }
    }
}
