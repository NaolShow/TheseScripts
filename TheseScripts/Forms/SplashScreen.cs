using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheseScripts.Classes;

namespace TheseScripts.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            Splash();
        }

        private async void Splash()
        {
            await Task.Delay(250);
            Startup.Start();
        }

    }
}
