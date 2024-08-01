using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaNegocio
{
    class CNLogin
    {
        public class ServicioUsuario
        {
            private AccesoDatos accesoDatos;

            public ServicioUsuario()
            {
                accesoDatos = new AccesoDatos();
            }

            public bool AutenticarUsuario(string usuario, string contrasena)
            {
                return accesoDatos.ValidarUsuario(usuario, contrasena);
            }
        }

    }
}
