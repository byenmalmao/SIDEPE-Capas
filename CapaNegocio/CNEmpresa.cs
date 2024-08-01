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
    public class CNEmpresa
    {
        public static string Insertar(int pIdEmpresa, string pNombre, string pDireccion, string pTelefono, string pCorreo, string pRNC)
        { 
            CDEmpresa objEmpresa = new CDEmpresa();
            objEmpresa.IdEmpresa = pIdEmpresa;
            objEmpresa.Nombre = pNombre;
            objEmpresa.Telefono = pTelefono;
            objEmpresa.Direccion = pDireccion;
            objEmpresa.Correo = pCorreo;
            objEmpresa.RNC = pRNC;
            
            return objEmpresa.Insertar(objEmpresa);
        }
        public static string Actualizar(int pIdEmpresa, string pNombre, string pDireccion, string pTelefono, string pCorreo, string pRNC)
        {
            CDEmpresa objEmpresa = new CDEmpresa();
            objEmpresa.IdEmpresa = pIdEmpresa;
            objEmpresa.Nombre = pNombre;
            objEmpresa.Telefono = pTelefono;
            objEmpresa.Direccion = pDireccion;
            objEmpresa.Correo = pCorreo;
            objEmpresa.RNC = pRNC;

            return objEmpresa.Actualizar(objEmpresa);
        }
        public DataTable ObtenerEmpresa(string miparametro)
        {
            CDEmpresa objEmpresa = new CDEmpresa();
            DataTable dt = new DataTable();

            dt = objEmpresa.EmpresaConsultar(miparametro);
            return dt;
        }

    }

}
