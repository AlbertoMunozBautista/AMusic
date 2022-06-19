using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMusic.Clases
{
    public class Cancion
    {
        public Cancion()
        {

        }

        public Cancion(String idCancion, String nombre, String cancion, String caratula, String genero, String artista, String fecha)
        {
            this.idCancion = idCancion;
            this.nombre = nombre;
            this.genero = genero;
            this.cancion = cancion;
            this.caratula = caratula;
            this.artista = artista;
            this.fecha = fecha;
        }

        public String idCancion { get; set; }
        public String nombre { get; set; }
        public String cancion { get; set; }
        public String caratula { get; set; }
        public String genero { get; set; }
        public String artista { get; set; }
        public String fecha { get; set; }

    }
}
