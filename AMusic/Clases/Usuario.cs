using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMusic.Clases
{
    public class Usuario
    {
        public Usuario() { }
        public Usuario(String nombre, String password, bool tipo, String correo, String telefono, String foto)
        {

            this.nombre = nombre;
            this.password = password;
            this.tipo = tipo;
            this.correo = correo;
            this.telefono = telefono;
            this.foto = foto;

        }


        public Usuario(String nombre, String password)
        {

            this.nombre = nombre;
            this.password = password;

        }

        public static bool loginCorreoPassword(Usuario u1, Usuario u2)
        {
            if (u1 == null || u2 == null)
            {
                return false;
            }

            if (u1.nombre != u2.nombre)
            {
                error = "El nombre de usuario no existe!";
                return false;
            }
            else if (u1.password != u2.password)
            {
                error = "La contraseña es incorrecta!";
                return false;
            }

            return true;
        }

        private static bool correoIgual(Usuario u1, String correoNuevo)
        {
            if (u1.correo.Equals(correoNuevo))
            {
                return false;
            }

            return true;
        }

        private static string error = "error";

        public static void showError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public String nombre { get; set; }
        public String password { get; set; }
        public bool tipo { get; set; }
        public String correo { get; set; }
        public String telefono { get; set; }
        public String foto { get; set; }

    }
}
