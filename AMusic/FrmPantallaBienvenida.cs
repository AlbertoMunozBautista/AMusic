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
    public partial class FrmPantallaBienvenida : Form
    {
        public FrmPantallaBienvenida()
        {
            InitializeComponent();
            timTiempo.Start();
        }

        private void timTiempo_Tick(object sender, EventArgs e)
        {
            timTiempo.Stop();         
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();

        }
    }
}
