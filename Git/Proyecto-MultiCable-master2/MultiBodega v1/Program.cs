using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Bodega;
using MultiBodega_v1.Botonera;

namespace MultiBodega_v1
{
    static class Program
    {

        public static Usuarios UsuarioSistema;

        /// <summary>
        /// Punto de entrada principal para la aplicación
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPantallaPrincipal());
        }
    }
}
