using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        //Variables globales para todo el proyecto/solución.

        public static int vidEmpleado = 0;

        public static int vidCargo = 0;

        public static int vidNave  = 0;

        public static int vidEmpresa= 0;



        public static bool nuevo = false;

        public static bool modificar = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
