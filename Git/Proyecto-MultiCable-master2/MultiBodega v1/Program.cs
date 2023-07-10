using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Bodega;
using MultiBodega_v1.Botonera;

namespace MultiBodega_v1
{
    public static class Program
    {

        //**********************************************************************************************************
        //Mis variables publicas globales
        public static string cUsuario;











        //***********************************************************************************************************



        /// <summary>
        /// Punto de entrada principal para la aplicación
        /// </summary>
        /// 

        public static class FormManager
        {
            public static Botonera_APP Botonera{ get; set; }

            // Otras variables estáticas para otros formularios...
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPantallaPrincipal());

            //********************************************************************************************************
            cUsuario="Prueba";
            







            //********************************************************************************************************




        }
    }
}
