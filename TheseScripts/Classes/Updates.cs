using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheseScripts.Properties;
using WolfLib;

namespace TheseScripts.Classes
{
    public static class Updates
    {

        public static void UpdateFiles()
        {
            try
            {
                // Merge update
                Rasu UpdateSettings = new Rasu(Resources.settings);
                Reference.RasuSettings.MergeFile(UpdateSettings);

                // Replace informations
                Reference.RasuSettings.Set("version", Application.ProductVersion);

                // Save
                File.WriteAllText(Reference.RasuSettings.GetFilePath(), UpdateSettings.GetFileContent());
                Reference.RasuSettings.ReloadFile();
            }
            catch (Exception ex)
            {
                Utils.ThrowException(ex);
            }
        }

        public static void Update()
        {
            try
            {
                Rasu DownloadInformations = new Rasu(new WebClient().DownloadString("https://dl.dropbox.com/s/79qs9izanj6elft/thesescripts_update.txt"));
                if (DownloadInformations.Get("version") != Application.ProductVersion)
                {
                    if (MessageBox.Show(Langs.Update, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(DownloadInformations.Get("setup_download"));
                    }
                }
            }
            catch (Exception ex) { Utils.ThrowException(ex); }
        }



    }
}
