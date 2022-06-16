using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMusic.Clases
{
    public class Favorito
    {
        public Favorito() { }

        public Favorito(String idFavorito, String usuario, String playlist)
        {
            this.idFavorito = idFavorito;
            this.playlist = playlist;
            this.usuario = usuario;
        }

        public String idFavorito { get; set; }
        public String usuario { get; set; }
        public String playlist { get; set; }
    }
}
