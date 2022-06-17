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

namespace AMusic
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            cargar();
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

    
        private void salir()
        {

            DialogResult dialogResult = MessageBox.Show("¿Desea salir de la aplicación?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void btnLogin1_Click_1(object sender, EventArgs e)
        {
            String user = txtUsuario.Texts;
            String password = txtPassword.Texts;


            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Rellene todos los campos!");
            }
            else
            {
                FirebaseResponse res = cliente.Get(@"Usuarios/" + user);
                Usuario resUsuario = res.ResultAs<Usuario>();
                Usuario curUsuario = new Usuario()
                {
                    nombre = user,
                    password = password
                };

                if (Usuario.loginCorreoPassword(resUsuario, curUsuario))
                {


                    //dependiendo del tipo de usuarion que esa se nos abrirá un menú u otro.
                    if (resUsuario.tipo)
                    {
                        FrmMenuAdmin frmMenuAdmin = new FrmMenuAdmin();
                        frmMenuAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        
                        FrmMenuUser frmMenuUser = new FrmMenuUser(resUsuario);
                        frmMenuUser.Show();
                        this.Hide();
                    }

                }

                else
                {
                    Usuario.showError();
                }

            }
        }

        private void btnLogin1_MouseEnter_1(object sender, EventArgs e)
        {
            btnLogin1.UseVisualStyleBackColor = false;
            btnLogin1.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 3, 150, 217);
        }

        private void btnLogin1_MouseLeave_1(object sender, EventArgs e)
        {
            btnLogin1.UseVisualStyleBackColor = true;
            btnLogin1.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 150, 217);
        }

        private void txtRegistro_Click_1(object sender, EventArgs e)
        {
            
            FrmRegistro frmRegistro = new FrmRegistro(this);
            frmRegistro.ShowDialog();
        }
    }
}

