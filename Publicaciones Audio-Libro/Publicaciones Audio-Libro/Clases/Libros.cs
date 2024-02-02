using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publicaciones_Audio_Libro
{
    public class Libros : Publicacion
    {
        private int num_pagina;

        [Browsable(true)]
        public int Num_pagina { get => num_pagina; set => num_pagina = value; }
    }
}
