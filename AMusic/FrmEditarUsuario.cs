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
using System.IO;
using Firebase.Storage;
using System.Collections;
using System.Net;

namespace AMusic
{
    public partial class FrmEditarUsuario : Form
    {
        private String nombreUsuario;
        String urlFoto;
        private Usuario u;
        String fotoActualizada = "";
        FrmMenuUser frmMenuUser;

        private ArrayList listaIdUsuario = new ArrayList();
        private ArrayList listaIdPlaylist = new ArrayList();

        public FrmEditarUsuario(String nombreUsuario, FrmMenuUser frmMenuUser)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.frmMenuUser = frmMenuUser;
            btnActualizar.Enabled = false;
            cargar();
            cargarDatos();
            cargarListaUsuarios();
            cargarListaPlaylist();

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

        private void cargarListaUsuarios()
        {
            FirebaseResponse res = cliente.Get(@"Seguido");
            Dictionary<string, Seguido> data = JsonConvert.DeserializeObject<Dictionary<string, Seguido>>(res.Body.ToString());
            rellenarListaUsuarios(data);
        }

        private void cargarListaPlaylist()
        {
            FirebaseResponse res = cliente.Get(@"Playlist");
            Dictionary<string, Playlist> data = JsonConvert.DeserializeObject<Dictionary<string, Playlist>>(res.Body.ToString());
            rellenarListaPlaylist(data);
        }

        private void rellenarListaUsuarios(Dictionary<string, Seguido> data)
        {

            lstUsuarios.Clear();
            lstUsuarios.Columns.Clear();

            lstUsuarios.Columns.Add("Nombre", 200);

            //lstLista.Columns.Add("Id", 0);


            foreach (var item2 in data)
            {
                if (item2.Value.usuarioSeguidor == nombreUsuario)
                {
                    String[] row = { item2.Value.usuarioSeguido };
                    var itemListView = new ListViewItem(row);
                    lstUsuarios.Items.Add(itemListView);
                    listaIdUsuario.Add(item2.Value.usuarioSeguido);
                }
            }



        }

        private void rellenarListaPlaylist(Dictionary<string, Playlist> data)
        {

            lstPlaylist.Clear();
            lstPlaylist.Columns.Clear();

            lstPlaylist.Columns.Add("Nombre", 200);
            lstPlaylist.Columns.Add("Id", 0);


            foreach (var item in data)
            {
                if (item.Value.usuario == nombreUsuario)
                {
                    String[] row = { item.Value.nombre, item.Value.idPlaylist };
                    var itemListView = new ListViewItem(row);
                    lstPlaylist.Items.Add(itemListView);
                    listaIdPlaylist.Add(item.Value.idPlaylist);
                }

            }
        }

        private void cargarDatos()
        {

            FirebaseResponse res = cliente.Get(@"Usuarios/" + nombreUsuario);
            u = res.ResultAs<Usuario>();

            var request = WebRequest.Create(u.foto);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                picFoto.Image = Bitmap.FromStream(stream);
            }

            txtUsuario.Text = u.nombre;
            txtCorreo.Texts = u.correo;
            txtPassword.Texts = u.password;
            txtTelefono.Texts = u.telefono;

        }

        private async void subirFoto(String urlFoto)
        {
            //limpiamos la imagen del picture box
            picFoto.Image.Dispose();
            //cogemos la url de la imagen
            var stream = File.Open(urlFoto, FileMode.Open);

            //cogemos el nombre de la imagen
            String nombreImagen = Path.GetFileName(urlFoto);

            //la insertamos
            var task = new FirebaseStorage("amusicprueba.appspot.com")
                     //Caratulas
                     //Usuarios                   
                     .Child("Images")
                     .Child("Usuarios")
                     .Child(nombreImagen)
                     .PutAsync(stream);



            // Await the task to wait until upload is completed and get the download url
            String downloadUrl = await task;

            fotoActualizada = downloadUrl;
        }

        private Playlist recuperarPlaylist()
        {
            int fila = lstPlaylist.FocusedItem.Index;
            String idPlaylist = listaIdPlaylist[fila].ToString();
            FirebaseResponse res = cliente.Get(@"Playlist/" + idPlaylist);
            Playlist playlist = res.ResultAs<Playlist>();
            return playlist;
        }

        private Usuario recuperarUsuarioActual()
        {
            String idUsuario = nombreUsuario;
            FirebaseResponse res = cliente.Get(@"Usuarios/" + idUsuario);
            Usuario usuario = res.ResultAs<Usuario>();
            return usuario;
        }

        private Usuario recuperarUsuario()
        {
            int fila = lstUsuarios.FocusedItem.Index;
            String idUsuario = listaIdUsuario[fila].ToString();
            FirebaseResponse res = cliente.Get(@"Usuarios/" + idUsuario);
            Usuario usuario = res.ResultAs<Usuario>();
            return usuario;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            subirFoto(urlFoto);
        }

        private void lstUsuarios_DoubleClick(object sender, EventArgs e)
        {
            Usuario u = recuperarUsuario();
            Usuario usuarioActual = recuperarUsuarioActual();

            this.Close();
            FrmUsuarios frmUsuarios = new FrmUsuarios(u, frmMenuUser, usuarioActual, true);
            frmUsuarios.MdiParent = frmMenuUser;
            frmUsuarios.Dock = DockStyle.Fill;
            frmUsuarios.Show();
        }

        private void lstPlaylist_DoubleClick(object sender, EventArgs e)
        {
            Playlist playlist = recuperarPlaylist();
            Usuario usuarioActual = recuperarUsuarioActual();

            this.Close();
            FrmListaCancionesPlaylist frmListaCancionesPlaylist = new FrmListaCancionesPlaylist(playlist, frmMenuUser, usuarioActual);
            frmListaCancionesPlaylist.MdiParent = frmMenuUser;
            frmListaCancionesPlaylist.Dock = DockStyle.Fill;
            frmListaCancionesPlaylist.Show();
        }

        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            //filtramos el openfile dialog 
            ofdFoto.Filter = "Imágenes(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            ofdFoto.FileName = "";

            //si elegimos la imagen, se cambia
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                btnActualizar.Enabled = true;
                picFoto.Image = new Bitmap(ofdFoto.FileName);
                urlFoto = ofdFoto.FileName;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void picPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar)
            {
                txtPassword.PasswordChar = false;
                picPassword.Image = AMusic.Properties.Resources.openeye;
            }
            else
            {
                txtPassword.PasswordChar = true;
                picPassword.Image = AMusic.Properties.Resources.closeeye;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String correo = txtCorreo.Texts;
            String password = txtPassword.Texts;
            String telefono = txtTelefono.Texts;


            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("No deje campos en blanco");
            }
            else
            {
                Usuario usuarioActualizado = new Usuario();

                if (fotoActualizada == "") //no ha cambiado la foto
                {

                    usuarioActualizado = new Usuario(u.nombre, password, u.tipo, correo, telefono, u.foto);

                }
                else //ha cambiado la foto
                {
                    usuarioActualizado = new Usuario(u.nombre, password, u.tipo, correo, telefono, fotoActualizada);

                    var request = WebRequest.Create(fotoActualizada);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        frmMenuUser.picFoto.Image = Bitmap.FromStream(stream);
                    }

                }

                cliente.Update("Usuarios/" + u.nombre, usuarioActualizado);

                MessageBox.Show("Usuario actualizado con éxito");
                this.Close();
            }
        }
    }
}
