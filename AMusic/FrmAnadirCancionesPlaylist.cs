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

namespace AMusic
{
    public partial class FrmAnadirCancionesPlaylist : Form
    {
        private Playlist playlist;
        private FrmMenuUser frmMenuUser;
        public FrmAnadirCancionesPlaylist(Playlist playlist, FrmMenuUser frmMenuUser)
        {
            InitializeComponent();
            this.playlist = playlist;
            this.frmMenuUser = frmMenuUser;
            cargar();
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
            FirebaseResponse res = cliente.Get(@"Cancion");
            Dictionary<string, Cancion> data = JsonConvert.DeserializeObject<Dictionary<string, Cancion>>(res.Body.ToString());
            rellenarLista(data);
        }

        private void rellenarLista(Dictionary<string, Cancion> data)
        {

            lstCanciones.Clear();
            lstCanciones.Columns.Clear();

            lstCanciones.Columns.Add("Nombre", 150);
            lstCanciones.Columns.Add("Artista", 150);
            lstCanciones.Columns.Add("Id", 0);

            foreach (var item in data)
            {
                String[] row = { item.Value.nombre, item.Value.artista, item.Value.idCancion };
                var itemListView = new ListViewItem(row);
                lstCanciones.Items.Add(itemListView);
            }
        }

   
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String cancion = txtBuscar.Text;

            FirebaseResponse res = cliente.Get(@"Cancion");
            Dictionary<string, Cancion> data = JsonConvert.DeserializeObject<Dictionary<string, Cancion>>(res.Body.ToString());

            lstCanciones.Clear();
            lstCanciones.Columns.Clear();

            lstCanciones.Columns.Add("Nombre", 150);
            lstCanciones.Columns.Add("Artista", 150);
            lstCanciones.Columns.Add("Id", 0);

            foreach (var item in data)
            {
                if (item.Value.nombre.ToLower().Contains(cancion.ToLower()))
                {
                    String[] row = { item.Value.nombre, item.Value.artista, item.Value.idCancion };
                    var itemListView = new ListViewItem(row);
                    lstCanciones.Items.Add(itemListView);
                }

            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (lstCanciones.SelectedItems.Count > 0)
            {

                cliente.Set(@"Playlist/" + playlist.idPlaylist, playlist);

                var items = lstCanciones.SelectedItems;
                for (int i = 0; i < items.Count; i++)
                {
                    Guid UUID = Guid.NewGuid();
                    String idCancionPlaylist = UUID.ToString();

                    CancionPlaylist cancionPlaylist = new CancionPlaylist(idCancionPlaylist, lstCanciones.SelectedItems[i].SubItems[2].Text.ToString(), playlist.idPlaylist);
                    cliente.Set(@"CancionPlaylist/" + idCancionPlaylist, cancionPlaylist);
                }

                MessageBox.Show("Playlist creado con éxito!");
                frmMenuUser.cargarLista();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione al menos una canción.");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
