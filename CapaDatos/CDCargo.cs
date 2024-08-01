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
    public class CDCargo
    {
        private int dIdCargo;
        private string dNombre, dFunciones, dEstado;

        public CDCargo()
        {

        }
        public CDCargo(int pIdCargo, string pNombre, string pFunciones, string pEstado)
        {
            dIdCargo = pIdCargo;
            dNombre = pNombre;
            dFunciones = pFunciones;
            dEstado = pEstado;
        }
        #region metodos get y set
        public int IdCargo
        {
            get { return dIdCargo; }
            set { dIdCargo = value; }
        }

        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }
        public string Funciones
        {
            get { return dFunciones; }
            set { dFunciones = value; }
        }
        

        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        #endregion
        public string Insertar(CDCargo objCargo)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = SIDEPEConexion.miconexion;

                SqlCommand micomando = new SqlCommand("CargoInsertar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pNombre", objCargo.Nombre);
                micomando.Parameters.AddWithValue("@pFunciones", objCargo.Funciones);
                micomando.Parameters.AddWithValue("@pEstado", objCargo.Estado);
                

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente!" :
                                               "No se pudo insertar correctamente los nuevos datos!";
            }
            catch (SqlException ex)
            {
                mensaje = $"Error en la base de datos: {ex.Message}";
            }
            catch (Exception ex)
            {
                mensaje = $"Error: {ex.Message}";
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;
        }

        public string Actualizar(CDCargo objCargo)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = SIDEPEConexion.miconexion;

                SqlCommand micomando = new SqlCommand("CargoActualizar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIdCargo", objCargo.IdCargo);
                micomando.Parameters.AddWithValue("@pNombre", objCargo.Nombre);
                micomando.Parameters.AddWithValue("@pFunciones", objCargo.Funciones);
                micomando.Parameters.AddWithValue("@pEstado", objCargo.Estado);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Datos actualizados correctamente!" :
                                            "No se pudo actualizar correctamente los datos!";
            }
            catch (SqlException ex)
            {
                mensaje = $"Error en la base de datos: {ex.Message}";
            }
            catch (Exception ex)
            {
                mensaje = $"Error: {ex.Message}";
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;
        }
        public DataTable CargoConsultar(String miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new SIDEPEConexion().dbconexion;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "CargoConsultar";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor",miparametro);
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
