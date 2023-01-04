using Proyecto_Final.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Iniciar_Sesion());
            //Application.Run(new Crear_Prof());
            //Application.Run(new Crear_Clase());
            //Application.Run(new Admin());
            //Application.Run(new Crear_Materia());
            //Application.Run(new Crear_User());
            //Application.Run(new Prefecto());
        }
    }
}
