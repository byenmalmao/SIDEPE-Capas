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
    public class CDNave
    {
        private int dIdNave, dEmpresa, dEncargado;
        private string dNombre, dCategoria, dUbicacion, dTelefono, dEstado;

        public CDNave()
        {

        }
        public CDNave(int pIdNave, string pNombre, string pCategoria, string pUbicacion, int pEncargado, string pTelefono, int pEmpresa, string pEstado)
        {
            dIdNave = pIdNave;
            dNombre = pNombre;
            dCategoria = pCategoria;
            dUbicacion = pUbicacion;
            dEncargado = pEncargado;
            dTelefono = pTelefono;
            dEmpresa = pEmpresa;
            dEstado = pEstado;
        }
        #region metodos get y set
        public int IdNave
        {
            get { return dIdNave; }
            set { dIdNave = value; }
        }

        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }
        public string Categoria
        {
            get { return dCategoria; }
            set { dCategoria = value; }
        }
        public string Ubicacion
        {
            get { return dUbicacion; }
            set { dUbicacion = value; }
        }

        public int Encargado
        {
            get { return dEncargado; }
            set { dEncargado = value; }
        }
        public string Telefono
        {
            get { return dTelefono; }
            set { dTelefono = value; }
        }

        /* public DataTable NaveConsultar(string miparametro)
         {
             throw new NotImplementedException();
         }
        */
        public int Empresa
        {
            get { return dEmpresa; }
            set { dEmpresa = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        #endregion
        public string Insertar(CDNave objNave)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = SIDEPEConexion.miconexion;

                SqlCommand micomando = new SqlCommand("NaveInsertar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pNombre", objNave.Nombre);
                micomando.Parameters.AddWithValue("@pCategoria", objNave.Categoria);
                micomando.Parameters.AddWithValue("@pUbicacion", objNave.Ubicacion);
                micomando.Parameters.AddWithValue("@pEncargado", objNave.Encargado);
                micomando.Parameters.AddWithValue("@pTelefono", objNave.Telefono);
                micomando.Parameters.AddWithValue("@pEmpresa", objNave.Empresa);
                micomando.Parameters.AddWithValue("@pEstado", objNave.Estado);


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

        public string Actualizar(CDNave objNave)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = SIDEPEConexion.miconexion;

                SqlCommand micomando = new SqlCommand("NaveActualizar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pNombre", objNave.Nombre);
                micomando.Parameters.AddWithValue("@pCategoria", objNave.Categoria);
                micomando.Parameters.AddWithValue("@pUbicacion", objNave.Ubicacion);
                micomando.Parameters.AddWithValue("@pEncargado", objNave.Encargado);
                micomando.Parameters.AddWithValue("@pTelefono", objNave.Telefono);
                micomando.Parameters.AddWithValue("@pEmpresa", objNave.Empresa);
                micomando.Parameters.AddWithValue("@pEstado", objNave.Estado);

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
        public DataTable NaveConsultar(String miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new SIDEPEConexion().dbconexion;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "NaveConsultar";
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