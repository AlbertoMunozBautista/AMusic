using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMusic.Clases
{
    public class Seguido
    {
        public Seguido() { }

        public Seguido(String idSeguido, String usuarioSeguidor, String usuarioSeguido)
        {
            this.idSeguido = idSeguido;
            this.usuarioSeguidor = usuarioSeguidor;
            this.usuarioSeguido = usuarioSeguido;
        }

        public String idSeguido { get; set; }
        public String usuarioSeguidor { get; set; }
        public String usuarioSeguido { get; set; }
    }
}
