using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMusic.Clases;

namespace AMusic
{
    public partial class FrmAnadirPlaylist : Form
    {
        private Usuario usuario;
        private FrmMenuUser frmMenuUser;
        public FrmAnadirPlaylist(Usuario usuario, FrmMenuUser frmMenuUser)
        {
            InitializeComponent();         
            this.usuario = usuario;
            this.frmMenuUser = frmMenuUser;
        }

           

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            Guid UUID = Guid.NewGuid();
            String idPlaylist = UUID.ToString();
            String idUsuario = usuario.nombre;
            String nombre = txtNombre.Texts;
            bool publico;

            if (chkPublico.Checked)
            {
                publico = true;
            }
            else
            {
                publico = false;
            }

            Playlist playlist = new Playlist(idPlaylist, nombre, idUsuario, publico);

            this.Close();
            FrmAnadirCancionesPlaylist frmAnadirCancionesPlaylist = new FrmAnadirCancionesPlaylist(playlist, frmMenuUser);
            frmAnadirCancionesPlaylist.ShowDialog();
        }
    }
}
