using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using AMusic.Clases;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Collections;

namespace AMusic
{
    public partial class FrmListaCancionesGenero : Form
    {
        private String idGenero;
        private FrmMenuUser frmMenuUser;
        ImageList imageList = new ImageList();
        ArrayList listaIdCanciones = new ArrayList();
        ArrayList listaCanciones = new ArrayList();
        int index = 0;
        public FrmListaCancionesGenero(String idGenero, FrmMenuUser frmMenuUser)
        {
            InitializeComponent();
            this.idGenero = idGenero;
            this.frmMenuUser = frmMenuUser;
            cargar();
            cargarComponentes();
            cargarLista();

        }

        private void cargarLista()
        {
            FirebaseResponse res = cliente.Get(@"Cancion");
            Dictionary<string, Cancion> data = JsonConvert.DeserializeObject<Dictionary<string, Cancion>>(res.Body.ToString());
            rellenarLista(data);

        }

        private void rellenarLista(Dictionary<string, Cancion> data)
        {
            listaIdCanciones.Clear();
            lstCancion.Clear();
            lstCancion.Columns.Clear();
            listaCanciones.Clear();


            foreach (var item in data)
            {

                if (item.Value.genero == idGenero)
                {
                    listaIdCanciones.Add(item.Value.idCancion);

                    Cancion c = new Cancion(item.Value.idCancion, item.Value.nombre, item.Value.cancion, item.Value.caratula, item.Value.genero, item.Value.artista, item.Value.fecha); ;
                    listaCanciones.Add(c);

                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData(item.Value.caratula);
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    ms.Dispose();

                    this.imageList.Images.Add(img);
                }
            }

            this.imageList.ImageSize = new Size(100, 100);
            this.lstCancion.View = View.Details;
            lstCancion.Columns.Add("", 300);


            lstCancion.SmallImageList = imageList;
            int cont = 0;
            foreach (var item in data)
            {
                if (item.Value.genero == idGenero)
                {
                    lstCancion.Items.Add(item.Value.nombre, cont);
                    cont++;

                }

            }
        }

        private void cargarComponentes()
        {
            FirebaseResponse res = cliente.Get(@"Genero/" + idGenero);
            Genero genero = res.ResultAs<Genero>();

            this.lblGenero.Text = genero.nombre;
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


        private void recuperarCancion()
        {

            int fila = lstCancion.FocusedItem.Index;
            index = fila;
            /*
            String idCancion = listaIdCanciones[fila].ToString();

            FirebaseResponse res = cliente.Get(@"Cancion/" + idCancion);
            Cancion cancion = res.ResultAs<Cancion>();*/

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String texto = txtBuscar.Text.ToLower();


            FirebaseResponse res = cliente.Get(@"Cancion");
            Dictionary<string, Cancion> data = JsonConvert.DeserializeObject<Dictionary<string, Cancion>>(res.Body.ToString());
            rellenarLista(data);

            listaIdCanciones.Clear();
            lstCancion.Clear();
            lstCancion.Columns.Clear();
            listaCanciones.Clear();

            foreach (var item in data)
            {

                if (item.Value.genero == idGenero && item.Value.nombre.ToLower().Contains(texto))
                {
                    listaIdCanciones.Add(item.Value.idCancion);

                    Cancion c = new Cancion(item.Value.idCancion, item.Value.nombre, item.Value.cancion, item.Value.caratula, item.Value.genero, item.Value.artista, item.Value.fecha); ;
                    listaCanciones.Add(c);

                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData(item.Value.caratula);
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    ms.Dispose();

                    this.imageList.Images.Add(img);
                }
            }

            this.imageList.ImageSize = new Size(100, 100);
            this.lstCancion.View = View.Details;
            lstCancion.Columns.Add("", 300);


            lstCancion.SmallImageList = imageList;
            int cont = 0;
            foreach (var item in data)
            {
                if (item.Value.genero == idGenero && item.Value.nombre.ToLower().Contains(texto))
                {
                    lstCancion.Items.Add(item.Value.nombre, cont);
                    cont++;

                }

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
