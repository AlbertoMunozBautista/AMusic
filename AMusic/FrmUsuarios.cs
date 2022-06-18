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
using System.Net;
using Newtonsoft.Json;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Collections;

namespace AMusic
{
    public partial class FrmUsuarios : Form
    {
        private Usuario usuario;
        private Usuario usuarioLogueado;
        private bool seguido;
        ArrayList listaIdPlaylist = new ArrayList();
        int index = 0;
        private FrmMenuUser frmMenuUser;

        public FrmUsuarios(Usuario usuario, FrmMenuUser frmMenuUser, Usuario usuarioLogueado, bool seguido)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.usuarioLogueado = usuarioLogueado;
            this.frmMenuUser = frmMenuUser;
            this.seguido = seguido;
            cargar();
            cargarLista();
            cargarBoton();
            var request = WebRequest.Create(usuario.foto);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                picUsuarios.Image = Bitmap.FromStream(stream);
            }
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "eqBhoT5oymn26ukYh7HfYGFx568xn9MIK8jrzo7a",
            BasePath = "https://amusicprueba-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient cliente;

        private void cargar()
        {
            try
            {
                cliente = new FireSharp.FirebaseClient(ifc);
            }
            catch (Exception)
            {

                throw; //no internet connection
            }
        }

        private void cargarBoton()
        {
            if (seguido)
            {
                botonRojo();
            }
            else
            {
                botonAzul();
            }
        }

        private void botonAzul()
        {
            btnSeguir2.Text = "Seguir";
            btnSeguir2.BackColor = Color.FromArgb(3, 150, 217);
        }

        private void botonRojo()
        {
            btnSeguir2.Text = "Dejar de seguir";
            btnSeguir2.BackColor = Color.FromArgb(250, 86, 75);
        }

        public void cargarLista()
        {
            FirebaseResponse res = cliente.Get(@"Playlist");
            Dictionary<string, Playlist> data = JsonConvert.DeserializeObject<Dictionary<string, Playlist>>(res.Body.ToString());
            rellenarLista(data);
        }

        private void rellenarLista(Dictionary<string, Playlist> data)
        {

            lstPlaylist.Clear();
            lstPlaylist.Columns.Clear();

            lstPlaylist.Columns.Add("Nombre", 75);
            lstPlaylist.Columns.Add("Id", 0);

            foreach (var item in data)
            {
                if (item.Value.usuario == usuario.nombre && item.Value.visibilidad)
                {
                    String[] row = { item.Value.nombre, item.Value.idPlaylist };
                    var itemListView = new ListViewItem(row);
                    lstPlaylist.Items.Add(itemListView);
                    listaIdPlaylist.Add(item.Value.idPlaylist);
                }

            }
        }

        private Playlist recuperarPlaylist()
        {
            int fila = lstPlaylist.FocusedItem.Index;
            index = fila;
            String idPlaylist = listaIdPlaylist[fila].ToString();
            //listaIdPlaylist.Clear();
            FirebaseResponse res = cliente.Get(@"Playlist/" + idPlaylist);
            Playlist playlist = res.ResultAs<Playlist>();
            return playlist;
        }

        private void lstPlaylist_DoubleClick(object sender, EventArgs e)
        {
            Playlist playlist = recuperarPlaylist();
            FrmListaCancionesPlaylist frmListaCancionesPlaylist = new FrmListaCancionesPlaylist(playlist, frmMenuUser, usuarioLogueado);
            frmListaCancionesPlaylist.MdiParent = frmMenuUser;
            frmListaCancionesPlaylist.Dock = DockStyle.Fill;
            frmListaCancionesPlaylist.Show();
        }

        private void btnSeguir2_Click(object sender, EventArgs e)
        {
            if (seguido)
            {
                String idSeguido = usuarioLogueado.nombre + usuario.nombre;
                cliente.Delete("Seguido/" + idSeguido);
                seguido = false;
                cargarBoton();
            }
            else
            {
                String idSeguido = usuarioLogueado.nombre + usuario.nombre;
                Seguido s = new Seguido(idSeguido, usuarioLogueado.nombre, usuario.nombre);
                SetResponse res = cliente.Set(@"Seguido/" + idSeguido, s);
                seguido = true;
                cargarBoton();
            }
        }
    }
}
