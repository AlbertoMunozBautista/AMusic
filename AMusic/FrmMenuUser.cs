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
using Newtonsoft.Json;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Collections;
using System.Drawing;
using System.Net;


namespace AMusic
{
    public partial class FrmMenuUser : Form
    {

        Usuario usuarioLogueado;
        ArrayList listaIdPlaylist = new ArrayList();
        ArrayList listaIDRepes = new ArrayList();
        int index = 0;

        public FrmMenuUser(Usuario usuarioLogueado)
        {
            InitializeComponent();

            this.usuarioLogueado = usuarioLogueado;


            cargar();
            cargarLista();
            // MessageBox.Show(usuarioLogueado.foto);
            //picFoto.ImageLocation = "";
            var request = WebRequest.Create(usuarioLogueado.foto);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                picFoto.Image = Bitmap.FromStream(stream);
            }

            cargarFormulario();

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


        public void cargarLista()
        {
            listaIdPlaylist.Clear();
            listaIDRepes.Clear();
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

            FirebaseResponse res = cliente.Get(@"Favorito");
            Dictionary<string, Favorito> dataFavoritos = JsonConvert.DeserializeObject<Dictionary<string, Favorito>>(res.Body.ToString());

            foreach (var item in data)
            {
                foreach (var item2 in dataFavoritos)
                {
                    if (item.Value.usuario == usuarioLogueado.nombre || (item2.Value.usuario == usuarioLogueado.nombre && item.Value.idPlaylist == item2.Value.playlist))
                    {
                        bool repe = false;
                        for (int i = 0; i < listaIDRepes.Count; i++)
                        {
                            if (item.Value.idPlaylist == listaIDRepes[i].ToString())
                            {
                                repe = true;
                            }
                        }

                        if (!repe)
                        {
                            listaIDRepes.Add(item.Value.idPlaylist);
                            String[] row = { item.Value.nombre, item.Value.idPlaylist };
                            var itemListView = new ListViewItem(row);
                            lstPlaylist.Items.Add(itemListView);
                            listaIdPlaylist.Add(item.Value.idPlaylist);

                        }

                    }


                }


            }
        }


        private void cargarFormulario()
        {
            FrmHome frmHome = new FrmHome(this);
            frmHome.MdiParent = this;
            frmHome.Dock = DockStyle.Fill;
            frmHome.Show();
        }



        private void salir()
        {

            DialogResult dialogResult = MessageBox.Show("¿Desea salir de la aplicación?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void picAnadir_Click(object sender, EventArgs e)
        {
            FrmAnadirPlaylist frmAnadirPlaylist = new FrmAnadirPlaylist(usuarioLogueado, this);
            frmAnadirPlaylist.ShowDialog();
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscar frmBuscar = new FrmBuscar(this, usuarioLogueado);
            frmBuscar.MdiParent = this;
            frmBuscar.Dock = DockStyle.Fill;
            frmBuscar.Show();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome(this);
            frmHome.MdiParent = this;
            frmHome.Dock = DockStyle.Fill;
            frmHome.Show();
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            FrmEditarUsuario frmEditarUsuario = new FrmEditarUsuario(usuarioLogueado.nombre, this);
            frmEditarUsuario.ShowDialog();
        }

        private void lstPlaylist_DoubleClick_1(object sender, EventArgs e)
        {
            Playlist playlist = recuperarPlaylist();
            FrmListaCancionesPlaylist frmListaCancionesPlaylist = new FrmListaCancionesPlaylist(playlist, this, usuarioLogueado);
            frmListaCancionesPlaylist.MdiParent = this;
            frmListaCancionesPlaylist.Dock = DockStyle.Fill;
            frmListaCancionesPlaylist.Show();
        }
    }
}
