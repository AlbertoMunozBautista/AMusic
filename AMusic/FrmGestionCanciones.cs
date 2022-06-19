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

namespace AMusic
{
    public partial class FrmGestionCanciones : Form
    {
        public FrmGestionCanciones()
        {
            InitializeComponent();
            cargar();
            cargarDatagrid();
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

        public void cargarDatagrid()
        {
            FirebaseResponse res = cliente.Get(@"Cancion");
            Dictionary<string, Cancion> data = JsonConvert.DeserializeObject<Dictionary<string, Cancion>>(res.Body.ToString());
            rellenarDataGrid(data);
        }

        private void rellenarDataGrid(Dictionary<string, Cancion> record)
        {
            dgvCanciones.Rows.Clear();
            dgvCanciones.Columns.Clear();

            dgvCanciones.Columns.Add("Nombre", "Nombre");
            dgvCanciones.Columns.Add("Artista", "Artista");
            dgvCanciones.Columns.Add("Fecha", "Fecha");
            dgvCanciones.Columns.Add("Género", "Género");
            dgvCanciones.Columns.Add("idCancion", "ID");
            dgvCanciones.Columns.Add("Canción", "Canción");
            dgvCanciones.Columns.Add("Carátula", "Carátul");

            dgvCanciones.Columns["idCancion"].Visible = false;

            foreach (var item in record)
            {
                String nGenero = getGenero(item.Value.genero);
                dgvCanciones.Rows.Add(item.Value.nombre, item.Value.artista, item.Value.fecha, nGenero, item.Value.idCancion, item.Value.cancion, item.Value.caratula);
            }

        }

        private String getGenero(String idGenero)
        {
            String nGenero = "";
            FirebaseResponse res = cliente.Get(@"Genero");
            Dictionary<string, Genero> data = JsonConvert.DeserializeObject<Dictionary<string, Genero>>(res.Body.ToString());

            foreach (var item in data)
            {
                if (item.Value.idGenero == idGenero)
                {
                    nGenero = item.Value.nombre;
                }
            }

            return nGenero;
        }

        private Cancion getSelectedSong()
        {
            int rowindex = dgvCanciones.CurrentCell.RowIndex;
            //int columnindex = dgvUsuarios.CurrentCell.ColumnIndex;

            String idCancion = dgvCanciones.Rows[rowindex].Cells[4].Value.ToString();

            //MessageBox.Show(nombreUsuario);

            FirebaseResponse result = cliente.Get(@"Cancion/" + idCancion);
            Cancion cancionSeleccionada = result.ResultAs<Cancion>();

            //MessageBox.Show(usuarioSeleccionado.nombre.ToString());

            return cancionSeleccionada;

        }

        private void modificarCancion()
        {
            if (dgvCanciones.SelectedRows.Count > 0)
            {
                Cancion cancionSeleccionada = getSelectedSong();
                FrmModificarCancion frmModificarCancion = new FrmModificarCancion(cancionSeleccionada, this);
                frmModificarCancion.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ninguna fila seleccionada!");
            }
        }


        
        private void salir()
        {

            DialogResult dialogResult = MessageBox.Show("¿Desea salir de la aplicación?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FrmMenuAdmin frmMenuAdmin = new FrmMenuAdmin();
            frmMenuAdmin.Show();
            this.Close();
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void btnAnadir1_Click_1(object sender, EventArgs e)
        {
            FrmAnadirCancion frmAnadirCancion = new FrmAnadirCancion(this);
            frmAnadirCancion.ShowDialog();
        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            modificarCancion();
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            if (dgvCanciones.SelectedRows.Count > 0)
            {

                DialogResult dialogResult = MessageBox.Show("¿Desea borrar la canción?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Cancion cancionSeleccionada = getSelectedSong();
                    cliente.Delete("Cancion/" + cancionSeleccionada.idCancion);

                    MessageBox.Show("Cancion eliminada con éxito!");
                    cargarDatagrid();
                }

            }
            else
            {
                MessageBox.Show("Ninguna fila seleccionada!");
            }
        }

        private void dgvCanciones_DoubleClick(object sender, EventArgs e)
        {
            modificarCancion();
        }
    }
}
