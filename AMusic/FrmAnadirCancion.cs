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
using System.IO;
using Firebase.Storage;

namespace AMusic
{
    public partial class FrmAnadirCancion : Form
    {
        String caratulaURL;
        String cancionURL;
        String caratulaStorage = "";
        String cancionStorage = "";

        ArrayList listaIdGenero = new ArrayList();
        ArrayList listaNombreGenero = new ArrayList();

        FrmGestionCanciones frmGestionCanciones;
        public FrmAnadirCancion(FrmGestionCanciones frmGestionCanciones)
        {
            InitializeComponent();
            this.frmGestionCanciones = frmGestionCanciones;
            cargar();
            cargarGeneros();

            this.btnAceptar1.Enabled = false;

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

        private void cargarGeneros()
        {

            FirebaseResponse res = cliente.Get(@"Genero");
            Dictionary<string, Genero> data = JsonConvert.DeserializeObject<Dictionary<string, Genero>>(res.Body.ToString());

            foreach (var item in data)
            {
                listaIdGenero.Add(item.Value.idGenero);
                listaNombreGenero.Add(item.Value.nombre);
            }

            for (int i = 0; i < listaNombreGenero.Count; i++)
            {
                this.cmbGenero.Items.Add(listaNombreGenero[i].ToString());
            }

            cmbGenero.SelectedIndex = 0;

        }


        private async void insertarCaratula()
        {
            //limpiamos la imagen del picture box
            picCaratula.Image.Dispose();

            //cogemos la url de la imagen
            var stream = File.Open(caratulaURL, FileMode.Open);

            //cogemos el nombre de la imagen
            String nombreImagen = Path.GetFileName(caratulaURL);

            //la insertamos
            var task = new FirebaseStorage("amusicprueba.appspot.com")
                     //Caratulas
                     //Usuarios                   
                     .Child("Images")
                     .Child("Caratulas")
                     .Child(nombreImagen)
                     .PutAsync(stream);


            // Await the task to wait until upload is completed and get the download url
            String downloadUrl = await task;

            caratulaStorage = downloadUrl;



        }

        private async void insertarCancion()
        {
            //cogemos la url de la cancion
            var stream = File.Open(cancionURL, FileMode.Open);

            //cogemos el nombre de la canción
            String nombreCancion = Path.GetFileName(cancionURL);

            //la insertamos
            var task = new FirebaseStorage("amusicprueba.appspot.com")
                //Caratulas
                //Usuarios
                .Child("Musica")
                .Child(nombreCancion)
                .PutAsync(stream);



            // Await the task to wait until upload is completed and get the download url

            task.Progress.ProgressChanged += (s, e) => prbProgreso.Value = e.Percentage;  //Console.WriteLine($"Progress: {e.Percentage} %");

            String downloadUrl = await task;

            cancionStorage = downloadUrl;

        }


        private void btnCaratula1_Click(object sender, EventArgs e)
        {
            //filtramos el openfile dialog 
            ofdCaratula.Filter = "Imágenes(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            ofdCaratula.FileName = "";

            //si elegimos la imagen, se cambia
            if (ofdCaratula.ShowDialog() == DialogResult.OK)
            {
                picCaratula.Image = new Bitmap(ofdCaratula.FileName);
                caratulaURL = ofdCaratula.FileName;

            }
        }

        private void btnCancion1_Click(object sender, EventArgs e)
        {
            //filtramos el openfile dialog 
            ofdCancion.Filter = "Canción(*.mp3;)|*.mp3;";
            ofdCancion.FileName = "";

            //si elegimos la imagen, se cambia
            if (ofdCancion.ShowDialog() == DialogResult.OK)
            {
                //picCaratula.Image = new Bitmap(ofdCaratula.FileName);
                //caratulaURL = ofdCaratula.FileName;

                cancionURL = ofdCancion.FileName;
                txtCancion.Text = Path.GetFileName(cancionURL);

            }
        }

        private void btnRecursos1_Click(object sender, EventArgs e)
        {
            progressTime.Enabled = true;

            insertarCaratula();
            insertarCancion();
        }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnAceptar1_Click_1(object sender, EventArgs e)
        {
            Guid UUID = Guid.NewGuid();
            String idCancion = UUID.ToString();
            String nombre = txtNombre.Text.ToString();
            String genero = this.listaIdGenero[cmbGenero.SelectedIndex].ToString();
            String artista = txtArtista.Text.ToString();
            String fecha = DateTime.Now.ToString("d");

            Cancion cancion = new Cancion(idCancion, nombre, cancionStorage, caratulaStorage, genero, artista, fecha);
            SetResponse res = cliente.Set(@"Cancion/" + idCancion, cancion);

            MessageBox.Show("Canción añadida");

            this.Close();
            frmGestionCanciones.cargarDatagrid();
        }

        private void progressTime_Tick(object sender, EventArgs e)
        {
            if (prbProgreso.Value == 100)
            {
                this.btnAceptar1.Enabled = true;
            }
        }
    }
}
