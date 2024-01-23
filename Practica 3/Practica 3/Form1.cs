using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form1 : Form
    {
        double pulgada_metros = 0;
        double pie_pulgada = 0;
        double suma_pies = 0;
        double lib_kg = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_libras_TextChanged(object sender, EventArgs e)
        {
            //una libras es igual a 0.453592 kg
            double libras, kg = 0.453592;

            libras = Convert.ToDouble(txt_libras.Text);
            lib_kg = libras * kg;
            lib_kg = Math.Round(lib_kg, 2);

            txt_peso_kg.Text = lib_kg.ToString() + "KG";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int edad;

            DateTime fecha_actual = DateTime.Today;
            edad = fecha_actual.Year - dateTimePicker1.Value.Year;
            if (fecha_actual < dateTimePicker1.Value.AddYears(edad)) edad--;

            txt_edad.Text = edad.ToString();
        }

        private void txt_pulgadas_TextChanged(object sender, EventArgs e)
        {
            double metros = 0.0254, pulgada_2;
            suma_pies = 0;

            pulgada_2 = Convert.ToDouble(txt_pulgadas.Text);
            suma_pies = pie_pulgada + pulgada_2;

            pulgada_metros = suma_pies * metros;

            txt_En_metros.Text = pulgada_metros.ToString() + "Metros";

            double potencia, imc;

            potencia = Math.Pow(pulgada_metros, 2);
            imc = lib_kg / potencia;
            imc = Math.Round(imc, 2);

            txt_imc.Text = imc.ToString();
        }

        private void txt_pies_TextChanged(object sender, EventArgs e)
        {
            double pie, pulgadas = 12;//un pie es igual a 12 pulgads

            pie = Convert.ToDouble(txt_pies.Text);
            pie_pulgada = pie * pulgadas;
        }
    }
}
