using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using CapaDatos;

namespace CapaNegocio
{
    public class CNCargo
    {
        public static string Insertar( string pNombre, string pFunciones, string pEstado)
        {
            CDCargo objCargo = new CDCargo();
           // objCargo.IdCargo = pIdCargo;
            objCargo.Nombre = pNombre;
            objCargo.Funciones = pFunciones;
            objCargo.Estado = pEstado;
            
            return objCargo.Insertar(objCargo);
        }
        public static string Actualizar(int pIdCargo, string pNombre, string pFunciones, string pEstado)
        {
            CDCargo objCargo = new CDCargo();
            objCargo.IdCargo = pIdCargo;
            objCargo.Nombre = pNombre;
            objCargo.Funciones = pFunciones;
            objCargo.Estado = pEstado;

            return objCargo.Actualizar(objCargo);
        }
        public DataTable ObtenerCargo(string miparametro)
        {
            CDCargo objCargo = new CDCargo();
            DataTable dt = new DataTable();

            dt = objCargo.CargoConsultar(miparametro);
            return dt;
        }
        public DataTable CargoConsultar(string vparametro)
        {
            throw new NotImplementedException();
        }
    }
    
}
