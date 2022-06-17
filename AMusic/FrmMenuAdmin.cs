using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMusic
{
    public partial class FrmMenuAdmin : Form
    {
        public FrmMenuAdmin()
        {
            InitializeComponent();
        }

        private void salir()
        {

            DialogResult dialogResult = MessageBox.Show("¿Desea salir de la aplicación?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            FrmGestionUsuarios frmGestionUsuarios = new FrmGestionUsuarios();
            frmGestionUsuarios.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmGestionCanciones frmGestionCanciones = new FrmGestionCanciones();
            frmGestionCanciones.Show();
            this.Hide();
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            salir();
        }
    }
}
