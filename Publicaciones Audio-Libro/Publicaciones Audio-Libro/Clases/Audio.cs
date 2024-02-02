using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publicaciones_Audio_Libro
{
    public class Audio : Publicacion
    {
        private int tiempo_minutos;

        [Browsable(true)]
        public int Tiempo_minutos { get => tiempo_minutos; set => tiempo_minutos = value; }
    }
}
