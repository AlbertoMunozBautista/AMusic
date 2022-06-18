using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using AMusic.Clases;
using Newtonsoft.Json;
using System.Collections;

namespace AMusic
{
    public partial class FrmBuscar : Form
    {
        ArrayList listaIdPlaylist = new ArrayList();
        ArrayList listaIdCancion = new ArrayList();
        ArrayList listaIdUsuario = new ArrayList();
        private int index;

        private Usuario usuario;

        private FrmMenuUser frmMenuUser;
        public FrmBuscar(FrmMenuUser frmMenuUser, Usuario usuarioLogueado)
        {
            InitializeComponent();
            cargar();
            this.frmMenuUser = frmMenuUser;
            this.usuario = usuarioLogueado;
            this.cmbFiltro.SelectedIndex = 0;
            index = 0;
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

        private void cargarListaCanciones()
        {
            FirebaseResponse res = cliente.Get(@"Cancion");
            Dictionary<string, Cancion> data = JsonConvert.DeserializeObject<Dictionary<string, Cancion>>(res.Body.ToString());
            rellenarListaCanciones(data);

        }

        private void cargarListaUsuarios()
        {
            FirebaseResponse res = cliente.Get(@"Usuarios");
            Dictionary<string, Usuario> data = JsonConvert.DeserializeObject<Dictionary<string, Usuario>>(res.Body.ToString());
            rellenarListaUsuarios(data);

        }

        private void cargarListaPlaylist()
        {
            FirebaseResponse res = cliente.Get(@"Playlist");
            Dictionary<string, Playlist> data = JsonConvert.DeserializeObject<Dictionary<string, Playlist>>(res.Body.ToString());
            rellenarListaPlaylist(data);
        }

        private void rellenarListaCanciones(Dictionary<string, Cancion> data)
        {

            lstLista.Clear();
            lstLista.Columns.Clear();
            listaIdCancion.Clear();

            lstLista.Columns.Add("Nombre", 150);
            lstLista.Columns.Add("Artista", 300);
            lstLista.Columns.Add("Id", 0);

            foreach (var item in data)
            {
                String[] row = { item.Value.nombre, item.Value.artista, item.Value.idCancion };
                var itemListView = new ListViewItem(row);
                lstLista.Items.Add(itemListView);
                listaIdCancion.Add(item.Value.idCancion);
            }
        }

        private void rellenarListaUsuarios(Dictionary<string, Usuario> data)
        {

            lstLista.Clear();
            lstLista.Columns.Clear();
            listaIdUsuario.Clear();

            lstLista.Columns.Add("Nombre", 75);
            lstLista.Columns.Add("Correo", 200);
            //lstLista.Columns.Add("Id", 0);

            foreach (var item in data)
            {
                if (!item.Value.tipo && item.Value.nombre != usuario.nombre)
                {
                    String[] row = { item.Value.nombre, item.Value.correo };
                    var itemListView = new ListViewItem(row);
                    lstLista.Items.Add(itemListView);
                    listaIdUsuario.Add(item.Value.nombre);
                }

            }
        }

        private void rellenarListaPlaylist(Dictionary<string, Playlist> data)
        {

            lstLista.Clear();
            lstLista.Columns.Clear();
            listaIdPlaylist.Clear();

            lstLista.Columns.Add("Nombre", 75);
            lstLista.Columns.Add("Id", 0);

            foreach (var item in data)
            {
                if (item.Value.visibilidad)
                {
                    String[] row = { item.Value.nombre, item.Value.idPlaylist };
                    var itemListView = new ListViewItem(row);
                    lstLista.Items.Add(itemListView);
                    listaIdPlaylist.Add(item.Value.idPlaylist);
                }

            }
        }

        private void cargarUsuarioSeleccionado()
        {
            Usuario u = recuperarUsuario();
            bool seguido = false;

            FirebaseResponse res = cliente.Get(@"Seguido");
            Dictionary<string, Seguido> data = JsonConvert.DeserializeObject<Dictionary<string, Seguido>>(res.Body.ToString());

            foreach (var item in data)
            {
                if (item.Value.usuarioSeguidor == usuario.nombre && item.Value.usuarioSeguido == u.nombre)
                {
                    seguido = true;
                }

            }

            FrmUsuarios frmUsuarios = new FrmUsuarios(u, frmMenuUser, usuario, seguido);
            frmUsuarios.MdiParent = frmMenuUser;
            frmUsuarios.Dock = DockStyle.Fill;
            frmUsuarios.Show();
        }

        private void cargarCancionSeleccionada()
        {
            Cancion c = recuperarCancion();
            ArrayList listaCanciones = new ArrayList();
            listaCanciones.Add(c);

            FrmReproductorMusica frmReproducirMusica = new FrmReproductorMusica(listaCanciones, 0);
            frmReproducirMusica.MdiParent = frmMenuUser;
            frmReproducirMusica.Dock = DockStyle.Fill;
            frmReproducirMusica.Show();
        }

        private void cargarPlaylistSeleccionada()
        {
            Playlist playlist = recuperarPlaylist();
            FrmListaCancionesPlaylist frmListaCancionesPlaylist = new FrmListaCancionesPlaylist(playlist, frmMenuUser, usuario);
            frmListaCancionesPlaylist.MdiParent = frmMenuUser;
            frmListaCancionesPlaylist.Dock = DockStyle.Fill;
            frmListaCancionesPlaylist.Show();
        }

        private Playlist recuperarPlaylist()
        {
            int fila = lstLista.FocusedItem.Index;
            index = fila;
            String idPlaylist = listaIdPlaylist[fila].ToString();
            FirebaseResponse res = cliente.Get(@"Playlist/" + idPlaylist);
            Playlist playlist = res.ResultAs<Playlist>();
            return playlist;
        }

        private Usuario recuperarUsuario()
        {
            int fila = lstLista.FocusedItem.Index;
            index = fila;
            String idUsuario = listaIdUsuario[fila].ToString();
            FirebaseResponse res = cliente.Get(@"Usuarios/" + idUsuario);
            Usuario usuario = res.ResultAs<Usuario>();
            return usuario;
        }

        private Cancion recuperarCancion()
        {
            int fila = lstLista.FocusedItem.Index;
            index = fila;
            String idCancion = listaIdCancion[fila].ToString();
            FirebaseResponse res = cliente.Get(@"Cancion/" + idCancion);
            Cancion cancion = res.ResultAs<Cancion>();
            return cancion;
        }


        private void cargarBuscarUsuario(String texto)
        {
            FirebaseResponse res = cliente.Get(@"Usuarios");
            Dictionary<string, Usuario> data = JsonConvert.DeserializeObject<Dictionary<string, Usuario>>(res.Body.ToString());

            lstLista.Clear();
            lstLista.Columns.Clear();
            listaIdUsuario.Clear();

            lstLista.Columns.Add("Nombre", 75);
            lstLista.Columns.Add("Correo", 200);
            //lstLista.Columns.Add("Id", 0);

            foreach (var item in data)
            {
                if (!item.Value.tipo && item.Value.nombre != usuario.nombre && item.Value.nombre.ToLower().Contains(texto))
                {
                    String[] row = { item.Value.nombre, item.Value.correo };
                    var itemListView = new ListViewItem(row);
                    lstLista.Items.Add(itemListView);
                    listaIdUsuario.Add(item.Value.nombre);
                }

            }
        }

        private void cargarBuscarCancion(String texto)
        {
            FirebaseResponse res = cliente.Get(@"Cancion");
            Dictionary<string, Cancion> data = JsonConvert.DeserializeObject<Dictionary<string, Cancion>>(res.Body.ToString());

            lstLista.Clear();
            lstLista.Columns.Clear();
            listaIdCancion.Clear();

            lstLista.Columns.Add("Nombre", 150);
            lstLista.Columns.Add("Artista", 300);
            lstLista.Columns.Add("Id", 0);

            foreach (var item in data)
            {
                if (item.Value.nombre.ToLower().Contains(texto))
                {
                    String[] row = { item.Value.nombre, item.Value.artista, item.Value.idCancion };
                    var itemListView = new ListViewItem(row);
                    lstLista.Items.Add(itemListView);
                    listaIdCancion.Add(item.Value.idCancion);
                }
            }
        }

        private void cargarBuscarPlaylist(String texto)
        {

            FirebaseResponse res = cliente.Get(@"Playlist");
            Dictionary<string, Playlist> data = JsonConvert.DeserializeObject<Dictionary<string, Playlist>>(res.Body.ToString());

            lstLista.Clear();
            lstLista.Columns.Clear();
            listaIdPlaylist.Clear();

            lstLista.Columns.Add("Nombre", 75);
            lstLista.Columns.Add("Id", 0);

            foreach (var item in data)
            {
                if (item.Value.visibilidad && item.Value.nombre.ToLower().Contains(texto))
                {
                    String[] row = { item.Value.nombre, item.Value.idPlaylist };
                    var itemListView = new ListViewItem(row);
                    lstLista.Items.Add(itemListView);
                    listaIdPlaylist.Add(item.Value.idPlaylist);
                }

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String texto = txtBuscar.Text.ToLower();
            if (cmbFiltro.SelectedIndex == 0)
            {
                cargarBuscarUsuario(texto);
            }
            else if (cmbFiltro.SelectedIndex == 1)
            {
                cargarBuscarCancion(texto);
            }
            else if (cmbFiltro.SelectedIndex == 2)
            {
                cargarBuscarPlaylist(texto);
            }
        }

        private void lstLista_DoubleClick(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == 0)
            {
                cargarUsuarioSeleccionado();
            }
            else if (cmbFiltro.SelectedIndex == 1)
            {
                cargarCancionSeleccionada();
            }
            else if (cmbFiltro.SelectedIndex == 2)
            {
                cargarPlaylistSeleccionada();
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == 0)
            {
                cargarListaUsuarios();
            }
            else if (cmbFiltro.SelectedIndex == 1)
            {
                cargarListaCanciones();
            }
            else if (cmbFiltro.SelectedIndex == 2)
            {
                cargarListaPlaylist();
            }
        }
    }
}
