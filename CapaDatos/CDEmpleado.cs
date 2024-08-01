using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace CapaDatos
{
    public class CDEmpleado
    {
        private int dIdEmpleado, dCargo, dNave;
        private string dNombre_Completo, dCedula, dGenero, dTelefono, dContacto_de_emergencia, dTipo_de_sangre, dNombre_Ars, dNumero_Afiliado_ARS, dCondiciones_medicas, dDireccion;

        public CDEmpleado()
        {

        }
        public CDEmpleado(int pIdEmpleado, string pNombre_Completo, string pCedula, string pGenero, string pTelefono, string pContacto_de_emergencia, string pTipo_de_sangre, string pNombre_Ars, string pNumero_Afiliado_ARS, string pCondiciones_medicas, string pDireccion, int pCargo, int pNave)
        {
            dIdEmpleado = pIdEmpleado;
            dNombre_Completo = pNombre_Completo;
            dCedula = pCedula;
            dGenero = pGenero;
            dTelefono = pTelefono;
            dContacto_de_emergencia = pContacto_de_emergencia;
            dTipo_de_sangre = pTipo_de_sangre;
            dNombre_Ars = pNombre_Ars;
            dNumero_Afiliado_ARS = pNumero_Afiliado_ARS;
            dCondiciones_medicas = pCondiciones_medicas;
            dDireccion = pDireccion;
            dCargo = pCargo;
            dNave = pNave;
        }
        #region metodos get y set
        public int IdEmpleado
        {
            get { return dIdEmpleado; }
            set { dIdEmpleado = value; }
        }

        public string Nombre_Completo
        {
            get { return dNombre_Completo; }
            set { dNombre_Completo = value; }
        }
        public string Cedula
        {
            get { return dCedula; }
            set { dCedula = value; }
        }
        public string Genero
        {
            get { return dGenero; }
            set { dGenero = value; }
        }
        public string Telefono
        {
            get { return dTelefono; }
            set { dTelefono = value; }
        }
        public string Contacto_de_emergencia
        {
            get { return dContacto_de_emergencia; }
            set { dContacto_de_emergencia = value; }
        }

        public string Tipo_de_sangre
        {
            get { return dTipo_de_sangre; }
            set { dTipo_de_sangre = value; }
        }

        public string Nombre_Ars
        {
            get { return dNombre_Ars; }
            set { dNombre_Ars = value; }
        }
        public string Numero_Afiliado_ARS
        {
            get { return dNumero_Afiliado_ARS; }
            set { dNumero_Afiliado_ARS = value; }
        }
        public string Condiciones_medicas
        {
            get { return dCondiciones_medicas; }
            set { dCondiciones_medicas = value; }
        }
        public string Direccion
        {
            get { return dDireccion; }
            set { dDireccion = value; }
        }
        public int Cargo
        {
            get { return dCargo; }
            set { dCargo = value; }
        }
        public int Nave
        {
            get { return dNave; }
            set { dNave = value; }
        }
        #endregion
        public string Insertar(CDEmpleado objEmpleado)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = SIDEPEConexion.miconexion;

                SqlCommand micomando = new SqlCommand("EmpleadoInsertar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pNombre_Completo", objEmpleado.Nombre_Completo);
                micomando.Parameters.AddWithValue("@pCedula", objEmpleado.Cedula);
                micomando.Parameters.AddWithValue("@pGenero", objEmpleado.Genero);
                micomando.Parameters.AddWithValue("@pTelefono", objEmpleado.Telefono);
                micomando.Parameters.AddWithValue("@pContacto_de_emergencia", objEmpleado.Contacto_de_emergencia);
                micomando.Parameters.AddWithValue("@pTipo_de_sangre", objEmpleado.Tipo_de_sangre);
                micomando.Parameters.AddWithValue("@pNombre_Ars", objEmpleado.Nombre_Ars);
                micomando.Parameters.AddWithValue("@pNumero_Afiliado_ARS", objEmpleado.Numero_Afiliado_ARS);
                micomando.Parameters.AddWithValue("@pCondiciones_medicas", objEmpleado.Condiciones_medicas);
                micomando.Parameters.AddWithValue("@pDireccion", objEmpleado.Direccion);
                micomando.Parameters.AddWithValue("@pCargo", objEmpleado.Cargo);
                micomando.Parameters.AddWithValue("@pNave", objEmpleado.Nave);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente!" :
                                               "No se pudo insertar correctamente los nuevos datos!";
            }

            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;
        }

        public string Actualizar(CDEmpleado objEmpleado)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = SIDEPEConexion.miconexion;

                SqlCommand micomando = new SqlCommand("EmpleadoActualizar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pNombre_Completo", objEmpleado.Nombre_Completo);
                micomando.Parameters.AddWithValue("@pCedula", objEmpleado.Cedula);
                micomando.Parameters.AddWithValue("@pGenero", objEmpleado.Genero);
                micomando.Parameters.AddWithValue("@pTelefono", objEmpleado.Telefono);
                micomando.Parameters.AddWithValue("@pContacto_de_emergencia", objEmpleado.Contacto_de_emergencia);
                micomando.Parameters.AddWithValue("@pTipo_de_sangre", objEmpleado.Tipo_de_sangre);
                micomando.Parameters.AddWithValue("@pNombre_Ars", objEmpleado.Nombre_Ars);
                micomando.Parameters.AddWithValue("@pNumero_Afiliado_ARS", objEmpleado.Numero_Afiliado_ARS);
                micomando.Parameters.AddWithValue("@pCondiciones_medicas", objEmpleado.Condiciones_medicas);
                micomando.Parameters.AddWithValue("@pDireccion", objEmpleado.Direccion);
                micomando.Parameters.AddWithValue("@pCargo", objEmpleado.Cargo);
                micomando.Parameters.AddWithValue("@pNave", objEmpleado.Nave);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Datos actualizados correctamente!" :
                                            "No se pudo actualizar correctamente los datos!";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;
        }
        public DataTable EmpleadoConsultar(String miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new SIDEPEConexion().dbconexion;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "EmpleadoConsultar";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro);
                leerDatos = sqlCmd.ExecuteReader();
                dt.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dt = null;
            }
            return dt;
        }

    }

}
