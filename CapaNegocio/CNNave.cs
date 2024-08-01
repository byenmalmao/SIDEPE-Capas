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
    public class CNNave
    {
        public static string Insertar(int pIdNave, string pNombre, string pCategoria, string pUbicacion, int pEncargado, string pTelefono, int pEmpresa, string pEstado)
        {
            CDNave objNave = new CDNave();
            objNave.IdNave = pIdNave;
            objNave.Nombre = pNombre;
            objNave.Categoria = pCategoria;
            objNave.Ubicacion = pUbicacion;
            objNave.Encargado = pEncargado;
            objNave.Telefono = pTelefono;
            objNave.Empresa = pEmpresa;
            objNave.Estado = pEstado;
            
            return objNave.Insertar(objNave);
        }
        public static string Actualizar(int pIdNave, string pNombre, string pCategoria, string pUbicacion, int pEncargado, string pTelefono, int pEmpresa, string pEstado)
        {
            CDNave objNave = new CDNave();
            objNave.IdNave = pIdNave;
            objNave.Nombre = pNombre;
            objNave.Categoria = pCategoria;
            objNave.Ubicacion = pUbicacion;
            objNave.Encargado = pEncargado;
            objNave.Telefono = pTelefono;
            objNave.Empresa = pEmpresa;
            objNave.Estado = pEstado;

            return objNave.Actualizar(objNave);
        }
        public DataTable ObtenerNave(string miparametro)
        {
            CDNave objNave = new CDNave();
            DataTable dt = new DataTable();

            dt = objNave.NaveConsultar(miparametro);
            return dt;
        }

        public DataTable NaveConsultar(int v, string vparametro)
        {
            throw new NotImplementedException();
        }

    }

}
