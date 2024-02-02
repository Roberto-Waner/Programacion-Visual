using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publicaciones_Audio_Libro
{
    abstract public class Publicacion
    {
        private string titulo;
        private decimal precio;

        [Browsable(true)]
        public string Titulo { get => titulo; set => titulo = value; }
        [Browsable(true)]
        public decimal Precio { get => precio; set => precio = value; }

        /*public void motrar (string @titulo, decimal @precio)
        {
            this.titulo = @titulo;
            this.precio = @precio;
        }*/
    }
}
