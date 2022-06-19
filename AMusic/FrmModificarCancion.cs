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
using System.Collections;
using System.IO;
using Firebase.Storage;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;


namespace AMusic
{
    public partial class FrmModificarCancion : Form
    {
        Cancion cancion;
        ArrayList listaIdGenero = new ArrayList();
        ArrayList listaNombreGenero = new ArrayList();
        FrmGestionCanciones frmGestionCanciones;

        public FrmModificarCancion(Cancion cancion, FrmGestionCanciones frmGestionCanciones)
        {
            InitializeComponent();
            this.cancion = cancion;
            this.frmGestionCanciones = frmGestionCanciones;
            cargar();
            cargarComponentes();
            cargarGeneros();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "eqBhoT5oymn26ukYh7HfYGFx568xn9MIK8jrzo7a",
            BasePath = "https://amusicprueba-default-rtdb.europe-west1.firebasedatabase.app/"
        };


        IFirebaseClient cliente;

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

            //cmbGenero.SelectedIndex = 0;

        }

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


        private void cargarComponentes()
        {
            FirebaseResponse result = cliente.Get(@"Genero/" + cancion.genero);
            Genero genero = result.ResultAs<Genero>();


            this.cmbGenero.Text = genero.nombre;
            this.txtArtista.Text = cancion.artista;
            this.txtNombre.Text = cancion.nombre;
        }

        

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAceptar1_Click(object sender, EventArgs e)
        {
            String artista = txtArtista.Text;
            String nombre = txtNombre.Text;
            Cancion c;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(artista))
            {
                MessageBox.Show("No puede dejar espacios en blanco");
                

            } else
            {
                try
                {
                    String genero = this.listaIdGenero[cmbGenero.SelectedIndex].ToString();
                    c = new Cancion(cancion.idCancion, nombre, cancion.cancion, cancion.caratula, genero, artista, cancion.fecha);
                }
                catch (Exception)
                {

                    c = new Cancion(cancion.idCancion, nombre, cancion.cancion, cancion.caratula, cancion.genero, artista, cancion.fecha);
                }

                cliente.Update("Cancion/" + cancion.idCancion, c);

                MessageBox.Show("Canción Modificada");

                this.Close();
                frmGestionCanciones.cargarDatagrid();
            }

           

            //FrmGestionCanciones frmGestionCancionesNuevo = new FrmGestionCanciones();
            //frmGestionCancionesNuevo.Show();
        }
    }
}
