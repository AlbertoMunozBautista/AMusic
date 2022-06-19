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
    public partial class FrmHome : Form
    {
        FrmMenuUser frmMenuUser;
        public FrmHome(FrmMenuUser frmMenuUser)
        {
            InitializeComponent();
            this.frmMenuUser = frmMenuUser;
        }

        private void cargarGenero(String idGenero)
        {
            FrmListaCancionesGenero frmListaCancionesGenero = new FrmListaCancionesGenero(idGenero, frmMenuUser);
            frmListaCancionesGenero.MdiParent = frmMenuUser;
            frmListaCancionesGenero.Dock = DockStyle.Fill;
            frmListaCancionesGenero.Show();
        }

        private void btnMusicaLatina_Click(object sender, EventArgs e)
        {
            cargarGenero("f7ea6e29-b415-46c2-adb1-67979c17377f");
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            cargarGenero("42e0f1cb-d53b-40a4-9f79-5f25010fd2d6");
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            cargarGenero("3f734a29-57a8-49fa-914d-372e14c5a4dd");
        }

        private void btnTechno_Click(object sender, EventArgs e)
        {
            cargarGenero("9c9e7ae7-b71c-4841-8ae7-5575a24aa5f7");
        }

        private void btnRap_Click(object sender, EventArgs e)
        {
            cargarGenero("ed740022-5b59-4efd-baff-d4e279c4b58a");
        }

        private void btnEdm_Click(object sender, EventArgs e)
        {
            cargarGenero("c0788c2d-a36a-4f4e-853a-4d8d87add721");
        }

        private void btnMusicaClasica_Click(object sender, EventArgs e)
        {
            cargarGenero("d10bd82c-fc00-46d4-94d9-c5be06c0706c");
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            cargarGenero("3c43930c-6f22-42e8-b715-0874b0575cb9");
        }

        private void btnMetal_Click(object sender, EventArgs e)
        {
            cargarGenero("3fe38352-5b16-4950-a689-3a1b893facf8");
        }

        private void btnTrap_Click(object sender, EventArgs e)
        {
            cargarGenero("dcaec483-bba5-4802-967a-0390a14b4c31");
        }

        private void btnFlamenco_Click(object sender, EventArgs e)
        {
            cargarGenero("4e02163c-81a1-4100-b33b-73c8900a8c1d");
        }

        private void btnJazz_Click(object sender, EventArgs e)
        {
            cargarGenero("93b22dab-d6d8-44aa-bf79-5a54bf5314a0");
        }

        private void btnSalsa_Click(object sender, EventArgs e)
        {
            cargarGenero("5d7d7297-4695-45a7-af1f-fd623b605be3");
        }

        private void btnBlues_Click(object sender, EventArgs e)
        {
            cargarGenero("6af2dc82-aa9a-4c82-b12c-f9aa13bf7607");
        }

        private void btnPunk_Click(object sender, EventArgs e)
        {
            cargarGenero("2b2012c7-05a3-4f23-9135-4edbf60080c9");
        }

        private void btnCumbia_Click(object sender, EventArgs e)
        {
            cargarGenero("bce1f9a5-03e6-4aaf-a21b-29fcb2a85377");
        }
    }
}
