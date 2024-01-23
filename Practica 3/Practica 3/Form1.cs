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

        /*private void txt_libras_TextChanged(object sender, EventArgs e)
        {
            //una libras es igual a 0.453592 kg
            double libras, kg = 0.453592;

            libras = Convert.ToDouble(txt_libras.Text);
            lib_kg = libras * kg;
            lib_kg = Math.Round(lib_kg, 2);

            txt_peso_kg.Text = lib_kg.ToString() + "KG";
        }*/

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int edad;

            DateTime fecha_actual = DateTime.Today;
            edad = fecha_actual.Year - dateTimePicker1.Value.Year;
            if (fecha_actual < dateTimePicker1.Value.AddYears(edad)) edad--;

            txt_edad.Text = edad.ToString();
        }

        /*private void txt_pulgadas_TextChanged(object sender, EventArgs e)
        {
            double metros = 0.0254, pulgada_2;
            suma_pies = 0;

            pulgada_2 = Convert.ToDouble(txt_pulgadas.Text);
            suma_pies = pie_pulgada + pulgada_2;

            pulgada_metros = suma_pies * metros;
            pulgada_metros = Math.Round(pulgada_metros, 2);

            txt_En_metros.Text = pulgada_metros.ToString() + "Metros";

            double potencia, imc;

            potencia = Math.Pow(pulgada_metros, 2);
            imc = lib_kg / potencia;
            imc = Math.Round(imc, 2);

            txt_imc.Text = imc.ToString();

            int cont_obeso = 0, cont_sobrepeso = 0, cont_delgado = 0, cont_normal = 0;
            string contextura = "";

            if (imc >= 30.00)
            {
                cont_obeso++;
                contextura = "Obeso";

            }else if(imc >= 25.00)
            {
                cont_sobrepeso++;
                contextura = "Sobrepeso";

            }else if(imc >= 18.5 && imc <= 24.99)
            {
                cont_normal++;
                contextura = "Normal";
            }
            else
            {
                cont_delgado++;
                contextura = "Delgado";
            }

            txt_contextura.Text = contextura.ToString();
        }*/

        /*private void txt_pies_TextChanged(object sender, EventArgs e)
        {
            double pie, pulgadas = 12;//un pie es igual a 12 pulgads

            pie = Convert.ToDouble(txt_pies.Text);
            pie_pulgada = pie * pulgadas;
        }*/

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            txt_no_estudiante.Clear();
            txt_matricula.Clear();
            txt_alumno.Clear();
            dateTimePicker1.Text = "";
            txt_libras.Clear();
            txt_pies.Clear();
            txt_pulgadas.Clear();
            txt_no_estudiante.Focus();
            txt_edad.Clear();
            txt_peso_kg.Clear();
            txt_En_metros.Clear();
            txt_contextura.Clear();
            txt_imc.Clear();
        }

        private void txt_libras_Validated(object sender, EventArgs e)
        {
            //una libras es igual a 0.453592 kg
            double libras, kg = 0.453592;

            libras = Convert.ToDouble(txt_libras.Text);
            lib_kg = libras * kg;
            lib_kg = Math.Round(lib_kg, 2);

            txt_peso_kg.Text = lib_kg.ToString() + "KG";
        }

        private void txt_pies_Validated(object sender, EventArgs e)
        {
            double pie, pulgadas = 12;//un pie es igual a 12 pulgads

            pie = Convert.ToDouble(txt_pies.Text);
            pie_pulgada = pie * pulgadas;
        }

        private void txt_pulgadas_Validated(object sender, EventArgs e)
        {
            double metros = 0.0254, pulgada_2;
            suma_pies = 0;

            pulgada_2 = Convert.ToDouble(txt_pulgadas.Text);
            suma_pies = pie_pulgada + pulgada_2;

            pulgada_metros = suma_pies * metros;
            pulgada_metros = Math.Round(pulgada_metros, 2);

            txt_En_metros.Text = pulgada_metros.ToString() + "Metros";

            double potencia, imc;

            potencia = Math.Pow(pulgada_metros, 2);
            imc = lib_kg / potencia;
            imc = Math.Round(imc, 2);

            txt_imc.Text = imc.ToString();

            int cont_obeso = 0, cont_sobrepeso = 0, cont_delgado = 0, cont_normal = 0;
            string contextura = "";

            if (imc >= 30.00)
            {
                cont_obeso++;
                contextura = "Obeso";

            }
            else if (imc >= 25.00)
            {
                cont_sobrepeso++;
                contextura = "Sobrepeso";

            }
            else if (imc >= 18.5 && imc <= 24.99)
            {
                cont_normal++;
                contextura = "Normal";
            }
            else
            {
                cont_delgado++;
                contextura = "Delgado";
            }

            txt_contextura.Text = contextura.ToString();
            txt_total1.Text = cont_normal.ToString();
            txt_total2.Text = cont_delgado.ToString();
            txt_total3.Text = cont_sobrepeso.ToString();
            txt_total4.Text = cont_obeso.ToString();
        }

        private void bt_enviar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txt_no_estudiante.Text, txt_matricula.Text, txt_alumno.Text, txt_edad.Text, txt_En_metros.Text, txt_peso_kg.Text, txt_imc.Text, txt_contextura.Text);
        }
    }
}
