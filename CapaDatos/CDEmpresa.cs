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
   public class CDEmpresa
    {
        private int dIdEmpresa;
        private string dNombre, dDireccion, dTelefono, dCorreo, dRNC;

        public CDEmpresa()
        {

        }
        public CDEmpresa(int pIdEmpresa, string pNombre, string pDireccion, string pTelefono, string pCorreo, string pRNC)
        {
            dIdEmpresa = pIdEmpresa;
            dNombre = pNombre;
            dDireccion = pDireccion;
            dTelefono = pTelefono;
            dCorreo = pCorreo;
            dRNC = pRNC;
        }
        #region metodos get y set
        public int IdEmpresa
        {
            get { return dIdEmpresa; }
            set { dIdEmpresa = value; }
        }

        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }
        public string Direccion
        {
            get { return dDireccion; }
            set { dDireccion = value; }
        }
        public string Telefono
        {
            get { return dTelefono; }
            set { dTelefono = value; }
        }
        
        public string Correo
        {
            get { return dCorreo; }
            set { dCorreo = value; }
        }
        public string RNC
        {
            get { return RNC; }
            set { dRNC = value; }
        }
        #endregion
        public string Insertar(CDEmpresa objEmpresa)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = SIDEPEConexion.miconexion;

                SqlCommand micomando = new SqlCommand("EmpresaInsertar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pNombre", objEmpresa.Nombre);
                micomando.Parameters.AddWithValue("@pDireccion", objEmpresa.Direccion);
                micomando.Parameters.AddWithValue("@pTelefono", objEmpresa.Telefono);
                micomando.Parameters.AddWithValue("@pCorreo", objEmpresa.Correo);
                micomando.Parameters.AddWithValue("@pRNC", objEmpresa.RNC);

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

        public string Actualizar(CDEmpresa objEmpresa)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = SIDEPEConexion.miconexion;

                SqlCommand micomando = new SqlCommand("EmpresaActualizar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pNombre", objEmpresa.Nombre);
                micomando.Parameters.AddWithValue("@pDireccion", objEmpresa.Direccion);
                micomando.Parameters.AddWithValue("@pTelefono", objEmpresa.Telefono);
                micomando.Parameters.AddWithValue("@pCorreo", objEmpresa.Correo);
                micomando.Parameters.AddWithValue("@pRNC", objEmpresa.RNC);

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
        public DataTable EmpresaConsultar(String miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new SIDEPEConexion().dbconexion;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "EmpresaConsultar";
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
