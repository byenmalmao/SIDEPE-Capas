using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class CDLogin
    {
        public class AccesoDatos
        {
            private string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\SIDEPE(Actalizacio_argenis)\\SIDEPE\\CapaDatos\\DBSIDEPE.mdf;Integrated Security=True";

            public bool ValidarUsuario(string usuario, string contrasena)
            {
                string sqlStr = "SELECT * FROM Usuarios WHERE Usuario = @usuario AND Contrasena = @contrasena";
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                        {
                            cmd.Parameters.AddWithValue("@usuario", usuario);
                            cmd.Parameters.AddWithValue("@contrasena", contrasena);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                return reader.HasRows;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción adecuadamente
                        throw new Exception("Error al validar el usuario", ex);
                    }
                }
            }
        }

    }
}
