using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publicaciones_Audio_Libro
{
    public partial class Form1 : Form
    {
        private BindingList<Libros> Publicar_libro = new BindingList<Libros>();
        private BindingList<Audio> Publicar_audio = new BindingList<Audio>();
        public Form1()
        {
            InitializeComponent();

        }

        private void rdbt_Libro_Click(object sender, EventArgs e)
        {
            txt_n_pag.Enabled = true;
            txt_tiempo.Enabled = false;
            txt_titulo.Enabled = true;
            txt_precio.Enabled = true;

            txt_n_pag.Clear();
            txt_tiempo.Clear();
            txt_titulo.Clear();
            txt_precio.Clear();
        }

        private void rdbt_audio_libro_CheckedChanged(object sender, EventArgs e)
        {
            txt_n_pag.Enabled = false;
            txt_tiempo.Enabled = true;
            txt_titulo.Enabled = true;
            txt_precio.Enabled = true;

            txt_n_pag.Clear();
            txt_tiempo.Clear();
            txt_titulo.Clear();
            txt_precio.Clear();
        }

        private void btn_capturar_Click(object sender, EventArgs e)
        {
            if(rdbt_Libro.Checked)
            {
                Libros libro_impr = new Libros
                {
                    Titulo = txt_titulo.Text,
                    Precio = Convert.ToDecimal(txt_precio.Text),
                    Num_pagina = Convert.ToInt32(txt_n_pag.Text)
                };
                Publicar_libro.Add(libro_impr);
                dgv_publicar_libro.DataSource = null;
                dgv_publicar_libro.DataSource = Publicar_libro;
            }
            
            if (rdbt_audio_libro.Checked)
            {
                Audio audio_libro = new Audio
                {
                    Titulo = txt_titulo.Text,
                    Precio = Convert.ToDecimal(txt_precio.Text),
                    Tiempo_minutos = Convert.ToInt32(txt_tiempo.Text)
                };
                Publicar_audio.Add(audio_libro);
                dgv_publicar_audio.DataSource = null;
                dgv_publicar_audio.DataSource = Publicar_audio;
            }          
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            /*Publicacion p_libro = (Publicacion)dgv_publicar_libro.SelectedRows[0].DataBoundItem;
            Publicacion p_audio = (Publicacion)dgv_publicar_audio.SelectedRows[0].DataBoundItem;*/

            if(dgv_publicar_libro.SelectedRows.Count > 0)
            {
                int ind_libro = dgv_publicar_libro.SelectedRows[0].Index;
                Publicacion p_libro = Publicar_libro[ind_libro];

                if (p_libro is Libros)
                {
                    Libros libro_imp = (Libros)p_libro;
                    txt_tiempo.Text = libro_imp.Titulo;
                    txt_precio.Text = libro_imp.Precio.ToString();
                    txt_n_pag.Text = libro_imp.Num_pagina.ToString();
                }

            }else if (dgv_publicar_audio.SelectedRows.Count > 0)
            {
                int ind_audio = dgv_publicar_libro.SelectedRows[0].Index;
                Publicacion p_audio = Publicar_libro[ind_audio];
                if (p_audio is Audio)
                {
                    Audio audio_libro = (Audio)p_audio;
                    txt_titulo.Text = audio_libro.Titulo;
                    txt_titulo.Text = audio_libro.Precio.ToString();
                    txt_tiempo.Text = audio_libro.Tiempo_minutos.ToString();
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_publicar_libro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_publicar_libro.SelectedRows.Count > 0)
            {
                int ind_libro = dgv_publicar_libro.SelectedRows[0].Index;
                Publicacion p_libro = Publicar_libro[ind_libro];

                if (p_libro is Libros)
                {
                    Libros libro_imp = (Libros)p_libro;
                    txt_tiempo.Text = libro_imp.Titulo;
                    txt_precio.Text = libro_imp.Precio.ToString();
                    txt_n_pag.Text = libro_imp.Num_pagina.ToString();
                }
            }
        }

        private void dgv_publicar_audio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_publicar_audio.SelectedRows.Count > 0)
            {
                int ind_audio = dgv_publicar_libro.SelectedRows[0].Index;
                Publicacion p_audio = Publicar_libro[ind_audio];
                if (p_audio is Audio)
                {
                    Audio audio_libro = (Audio)p_audio;
                    txt_titulo.Text = audio_libro.Titulo;
                    txt_titulo.Text = audio_libro.Precio.ToString();
                    txt_tiempo.Text = audio_libro.Tiempo_minutos.ToString();
                }
            }
        }
    }
}
