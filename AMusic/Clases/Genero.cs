using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMusic.Clases
{
    public class Genero
    {
        public Genero()
        {

        }

        public Genero(String idGenero, String nombre)
        {
            this.idGenero = idGenero;
            this.nombre = nombre;
        }

        public String idGenero { get; set; }
        public String nombre { get; set; }

    }
}
