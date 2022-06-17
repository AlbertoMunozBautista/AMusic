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
    public partial class FrmGestionUsuarios : Form
    {
        public FrmGestionUsuarios()
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

        private void cargarDatagrid()
        {
            FirebaseResponse res = cliente.Get(@"Usuarios");
            Dictionary<string, Usuario> data = JsonConvert.DeserializeObject<Dictionary<string, Usuario>>(res.Body.ToString());
            rellenarDataGrid(data);
        }

        private void rellenarDataGrid(Dictionary<string, Usuario> record)
        {
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Columns.Clear();

            dgvUsuarios.Columns.Add("usuario", "Usuario");
            dgvUsuarios.Columns.Add("correo", "Correo");
            dgvUsuarios.Columns.Add("contraseña", "Contraseña");
            dgvUsuarios.Columns.Add("telefono", "Teléfono");
            dgvUsuarios.Columns.Add("tipo", "Admin");
            dgvUsuarios.Columns.Add("foto", "Foto");

            foreach (var item in record)
            {
                dgvUsuarios.Rows.Add(item.Value.nombre, item.Value.correo, item.Value.password, item.Value.telefono, item.Value.tipo, item.Value.foto);
            }

        }


        private Usuario getSelectedUser()
        {
            int rowindex = dgvUsuarios.CurrentCell.RowIndex;
            //int columnindex = dgvUsuarios.CurrentCell.ColumnIndex;

            String nombreUsuario = dgvUsuarios.Rows[rowindex].Cells[0].Value.ToString();

            //MessageBox.Show(nombreUsuario);

            FirebaseResponse result = cliente.Get(@"Usuarios/" + nombreUsuario);
            Usuario usuarioSeleccionado = result.ResultAs<Usuario>();

            //MessageBox.Show(usuarioSeleccionado.nombre.ToString());

            return usuarioSeleccionado;

        }


        private void salir()
        {

            DialogResult dialogResult = MessageBox.Show("¿Desea salir de la aplicación?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMenuAdmin frmMenuAdmin = new FrmMenuAdmin();
            frmMenuAdmin.Show();
            this.Close();
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {

                DialogResult dialogResult = MessageBox.Show("¿Desea borrar el usuario?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Usuario usuarioSeleccionado = getSelectedUser();
                    cliente.Delete("Usuarios/" + usuarioSeleccionado.nombre);

                    MessageBox.Show("Usuario eliminado con éxito!");
                    cargarDatagrid();
                }


            }
            else
            {
                MessageBox.Show("Ninguna fila seleccionada!");
            }

        }
    }
}
