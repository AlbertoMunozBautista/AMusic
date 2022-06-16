using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMusic.Clases
{
    public class Playlist
    {
        public Playlist() { }

        public Playlist(String idPlaylist, String nombre, String usuario, bool visibilidad)
        {
            this.idPlaylist = idPlaylist;
            this.nombre = nombre;
            this.usuario = usuario;
            this.visibilidad = visibilidad;
        }

        public String idPlaylist { get; set; }
        public String usuario { get; set; }
        public bool visibilidad { get; set; }
        public String nombre { get; set; }

    }
}
