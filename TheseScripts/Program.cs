using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheseScripts.Classes;
using TheseScripts.Forms;

namespace TheseScripts
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Instanciate Main Form and show her
            Reference.SplashForm = new SplashScreen();
            Application.Run(Reference.SplashForm);
        }
    }
}
