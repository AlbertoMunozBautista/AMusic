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
using System.Text.RegularExpressions;

namespace AMusic
{
    public partial class FrmRegistro : Form
    {
        FrmLogin frmLogin;
        public FrmRegistro(FrmLogin frmLogin)
        {
            InitializeComponent();
            cargar();
            this.frmLogin = frmLogin;
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


        private bool comprobarUsuario(ArrayList listaUsuarios, String usuario)
        {
            bool usuarioRepetido = false;

            for (int i = 0; i < listaUsuarios.Count; i++)
            {

                Usuario u = (Usuario)listaUsuarios[i];
                if (u.nombre == usuario)
                {
                    usuarioRepetido = true;
                }
            }

            return usuarioRepetido;
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar1_Click(object sender, EventArgs e)
        {
            String user = txtUsuario.Texts;
            String password = txtPassword.Texts;
            String correo = txtCorreo.Texts;
            String telefono = txtTelefono.Texts;
            String foto = "https://firebasestorage.googleapis.com/v0/b/amusicprueba.appspot.com/o/Images%2FUsuarios%2Fperfil.png?alt=media&token=f73a063d-dc44-48de-a251-8333b8ea453a";

            bool usuarioRepetido;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (validarCorreo(correo))
                {

                    if (validarTelefono(telefono))
                    {
                        //se crea una lista de usuarios
                        ArrayList listaUsuarios = new ArrayList();

                        //se obtienen todos los usuarios de la tabla usuarios y se guardan en un diccionario
                        FirebaseResponse res = cliente.Get(@"Usuarios");
                        Dictionary<string, Usuario> data = JsonConvert.DeserializeObject<Dictionary<string, Usuario>>(res.Body.ToString());


                        //por cada item del diccionario se crea un objeto usuario que se guarda en la lista de usuarios
                        foreach (var item in data)
                        {
                            Usuario u = new Usuario(item.Value.nombre, item.Value.password, item.Value.tipo, item.Value.correo, item.Value.telefono, item.Value.foto);
                            listaUsuarios.Add(u);
                        }

                        //se envía la lista de usuarios y el usuario que ha intentado registrarse
                        usuarioRepetido = comprobarUsuario(listaUsuarios, user);

                        //MessageBox.Show(usuarioRepetido.ToString());


                        //si el usuario no está repetido, regitramos al usuario y nos vamos al menú

                        if (!usuarioRepetido)
                        {
                            Usuario usuario = new Usuario(user, password, false, correo, telefono, foto);
                            SetResponse ress = cliente.Set(@"Usuarios/" + user, usuario);

                            MessageBox.Show("Usuario registrado con éxito!");

                            //cerramos
                            this.Hide();
                            frmLogin.Hide();

                            FrmMenuUser frmMenuUser = new FrmMenuUser(usuario);
                            frmMenuUser.Show();

                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario no disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("El formato del teléfono no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("El formato del correo no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static bool validarTelefono(string telNo)
        {
            return Regex.Match(telNo, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$").Success;
        }

        private bool validarCorreo(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
