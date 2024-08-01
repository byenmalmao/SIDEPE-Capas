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
    public class CNEmpleado
    {
        public static string Insertar(int pIdEmpleado, string pNombre_Completo, string pCedula, string pGenero, string pTelefono, string pContacto_de_emergencia, string pTipo_de_sangre, string pNombre_Ars, string pNumero_Afiliado_ARS, string pCondiciones_medicas, string pDireccion, int pCargo, int pNave)
        {
            CDEmpleado objEmpleado = new CDEmpleado();
            objEmpleado.IdEmpleado = pIdEmpleado;
            objEmpleado.Nombre_Completo = pNombre_Completo;
            objEmpleado.Cedula = pCedula;
            objEmpleado.Genero = pGenero;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.Contacto_de_emergencia = pContacto_de_emergencia;
            objEmpleado.Tipo_de_sangre = pTipo_de_sangre;
            objEmpleado.Nombre_Ars = pNombre_Ars;
            objEmpleado.Numero_Afiliado_ARS = pNumero_Afiliado_ARS;
            objEmpleado.Condiciones_medicas = pCondiciones_medicas;
            objEmpleado.Direccion = pDireccion;
            objEmpleado.Cargo = pCargo;
            objEmpleado.Nave = pNave;

            return objEmpleado.Insertar(objEmpleado);
        }
        public static string Actualizar(int pIdEmpleado, string pNombre_Completo, string pCedula, string pGenero, string pTelefono, string pContacto_de_emergencia, string pTipo_de_sangre, string pNombre_Ars, string pNumero_Afiliado_ARS, string pCondiciones_medicas, string pDireccion, int pCargo, int pNave)
        {
            CDEmpleado objEmpleado = new CDEmpleado();
            objEmpleado.IdEmpleado = pIdEmpleado;
            objEmpleado.Nombre_Completo = pNombre_Completo;
            objEmpleado.Cedula = pCedula;
            objEmpleado.Genero = pGenero;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.Contacto_de_emergencia = pContacto_de_emergencia;
            objEmpleado.Tipo_de_sangre = pTipo_de_sangre;
            objEmpleado.Nombre_Ars = pNombre_Ars;
            objEmpleado.Numero_Afiliado_ARS = pNumero_Afiliado_ARS;
            objEmpleado.Condiciones_medicas = pCondiciones_medicas;
            objEmpleado.Direccion = pDireccion;
            objEmpleado.Cargo = pCargo;
            objEmpleado.Nave = pNave;

            return objEmpleado.Actualizar(objEmpleado);
        }
        public DataTable ObtenerEmpleado(string miparametro)
        {
            CDEmpleado objEmpleado = new CDEmpleado();
            DataTable dt = new DataTable();

            dt = objEmpleado.EmpleadoConsultar(miparametro);
            return dt;
        }

        /* public static string Actualizar(int vidEmpleado, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, string text10, int vidCargo, int vidNave)
         {
             throw new NotImplementedException();
         }

         public static string Insertar(int vidEmpleado, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, string text10, int vidCargo, int vidNave)
         {
             throw new NotImplementedException();
         }*/

        public DataTable EmpleadoConsultar(string miparametro)
        {
            throw new NotImplementedException();
        }
    }
}

