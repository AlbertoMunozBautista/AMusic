using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using AMusic.Clases;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Collections;

namespace AMusic
{
    public partial class FrmListaCancionesPlaylist : Form
    {
        private bool editable = false;
        private Playlist playlist;
        private ArrayList listaIdCanciones = new ArrayList();
        private ArrayList listaCanciones = new ArrayList();
        private Usuario usuarioLogueado;
        private int index = 0;
        private FrmMenuUser frmMenuUser;
        private bool favorito;

        public FrmListaCancionesPlaylist(Playlist playlist, FrmMenuUser frmMenuUser, Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.playlist = playlist;
            this.frmMenuUser = frmMenuUser;
            this.usuarioLogueado = usuarioLogueado;
            listaIdCanciones.Clear();
            listaCanciones.Clear();
            cargar();
            cargarComponentes();
            cargarLista();
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

        private void cargarLista()
        {
            FirebaseResponse res = cliente.Get(@"CancionPlaylist");
            Dictionary<string, CancionPlaylist> data = JsonConvert.DeserializeObject<Dictionary<string, CancionPlaylist>>(res.Body.ToString());
            rellenarLista(data);
        }

        private void rellenarLista(Dictionary<string, CancionPlaylist> data)
        {

            foreach (var item in data)
            {
                if (item.Value.playlist == playlist.idPlaylist)
                {
                    listaIdCanciones.Add(item.Value.cancion);
                }

            }

            lstCancion.Clear();
            lstCancion.Columns.Clear();

            lstCancion.Columns.Add("Nombre", 150);
            lstCancion.Columns.Add("Artista", 150);
            lstCancion.Columns.Add("Id", 0);


            FirebaseResponse res = cliente.Get(@"Cancion");
            Dictionary<string, Cancion> data2 = JsonConvert.DeserializeObject<Dictionary<string, Cancion>>(res.Body.ToString());

            foreach (var item in data2)
            {
                for (int i = 0; i < listaIdCanciones.Count; i++)
                {
                    if (item.Value.idCancion == listaIdCanciones[i].ToString())
                    {
                        Cancion c = new Cancion(item.Value.idCancion, item.Value.nombre, item.Value.cancion, item.Value.caratula, item.Value.genero, item.Value.artista, item.Value.fecha);
                        listaCanciones.Add(c);
                        String[] row = { item.Value.nombre, item.Value.artista, item.Value.idCancion };
                        var itemListView = new ListViewItem(row);
                        lstCancion.Items.Add(itemListView);
                    }
                }

            }


        }

        private void cargarComponentes()
        {
            this.lblNombre.Text = playlist.nombre;
            this.lblUsuario.Text = playlist.usuario;

            favorito = comprobarFavorito();
            dibujarCorazon(favorito);

            if (usuarioLogueado.nombre == playlist.usuario)
            {
                picBorrar.Enabled = true;
            }
            else
            {
                picBorrar.Enabled = false;
            }

        }

        private void dibujarCorazon(bool favorito)
        {
            if (usuarioLogueado.nombre == playlist.usuario)
            {
                picCorazon.Image = Properties.Resources.megustaGris;
                editable = false;

            }
            else
            {
                editable = true;
                if (favorito)
                {
                    corazonRojo();
                }
                else
                {
                    corazonNegro();
                }
            }

        }

        private void corazonRojo()
        {
            picCorazon.Image = Properties.Resources.megusta;

        }

        private void corazonNegro()
        {
            picCorazon.Image = Properties.Resources.nomegusta;
        }

        private bool comprobarFavorito()
        {
            bool favorito = false;
            FirebaseResponse res = cliente.Get(@"Favorito");
            Dictionary<string, Favorito> data = JsonConvert.DeserializeObject<Dictionary<string, Favorito>>(res.Body.ToString());

            foreach (var item in data)
            {
                if (item.Value.playlist == playlist.idPlaylist && item.Value.usuario == usuarioLogueado.nombre)
                {
                    favorito = true;
                }

            }

            return favorito;
        }


        private void recuperarCancion()
        {

            int fila = lstCancion.FocusedItem.Index;
            index = fila;

        }

        private void picBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea borrar la playlist?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                cliente.Delete("Playlist/" + playlist.idPlaylist);
                frmMenuUser.cargarLista();
                MessageBox.Show("Playlist borrada con éxito.");

                FrmHome frmHome = new FrmHome(frmMenuUser);
                frmHome.MdiParent = frmMenuUser;
                frmHome.Dock = DockStyle.Fill;
                frmHome.Show();
            }
        }

        private void picReproducir_Click(object sender, EventArgs e)
        {
            FrmReproductorMusica frmReproducirMusica = new FrmReproductorMusica(listaCanciones, 0);
            frmReproducirMusica.MdiParent = frmMenuUser;
            frmReproducirMusica.Dock = DockStyle.Fill;
            frmReproducirMusica.Show();
        }

        private void picCorazon_Click(object sender, EventArgs e)
        {
            if (editable)
            {
                if (favorito)
                {
                    String idFavorito = usuarioLogueado.nombre + playlist.nombre;
                    cliente.Delete("Favorito/" + idFavorito);
                    favorito = false;
                    dibujarCorazon(favorito);

                }
                else
                {
                    String idFavorito = usuarioLogueado.nombre + playlist.nombre;
                    Favorito f = new Favorito(idFavorito, usuarioLogueado.nombre, playlist.idPlaylist);
                    cliente.Set(@"Favorito/" + idFavorito, f);
                    favorito = true;
                    dibujarCorazon(favorito);
                }
                frmMenuUser.cargarLista();
            }
        }

        private void lstCancion_DoubleClick(object sender, EventArgs e)
        {
            recuperarCancion();
            FrmReproductorMusica frmReproducirMusica = new FrmReproductorMusica(listaCanciones, index);
            frmReproducirMusica.MdiParent = frmMenuUser;
            frmReproducirMusica.Dock = DockStyle.Fill;
            frmReproducirMusica.Show();
        }
    }
}
