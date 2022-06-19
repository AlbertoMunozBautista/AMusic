using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMusic.Clases
{
    public class CancionPlaylist
    {
        public CancionPlaylist() { }

        public CancionPlaylist(String idCancionPlaylist, String cancion, String playlist)
        {
            this.idCancionPlaylist = idCancionPlaylist;
            this.cancion = cancion;
            this.playlist = playlist;
        }

        public String idCancionPlaylist { get; set; }
        public String cancion { get; set; }
        public String playlist { get; set; }
    }
}
