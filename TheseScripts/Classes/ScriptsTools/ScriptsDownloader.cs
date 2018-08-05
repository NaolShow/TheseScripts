using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheseScripts.Classes.ScriptsTools
{
    public static class ScriptsDownloader
    {

        // Variables
        private static String scripts_list_download = "https://dl.dropbox.com/s/j22qckerfvi6age/scripts_list.txt";
        private static WebClient scripts_list_downloader;

        #region "Scripts list download"

        // This function simply downloads the list of scripts
        public static void RetrieveScriptsList()
        {
            try
            {
                scripts_list_downloader = new WebClient();
                scripts_list_downloader.DownloadStringCompleted += new DownloadStringCompletedEventHandler(scripts_list_downloader_DownloadStringCompleted);
                scripts_list_downloader.DownloadStringAsync(new Uri(scripts_list_download));
            }
            // A message is sent if the user does not have an internet connection
            catch { MessageBox.Show(Langs.NoConnection, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); scripts_list_downloader.CancelAsync(); }
        }

        // This function retrieves the list of downloaded scripts, and adds scripts to a list
        private static void scripts_list_downloader_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Reference.MainForm.ScriptsImporter_List.Items.Clear();
            foreach (String line in e.Result.Split( new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None))
            {
                if (!line.StartsWith("//"))
                {
                    String[] args = line.Split(',');

                    if (Reference.MAP_type.Equals(args[0], StringComparison.CurrentCultureIgnoreCase))
                    {
                        ListViewItem item = new ListViewItem(args[2]);
                        item.SubItems.Add(args[3]);
                        item.SubItems.Add(args[4]);
                        item.SubItems.Add(".");

                        ScriptObject so = new ScriptObject(args);
                        item.Tag = so;

                        int GroupIndex = Convert.ToInt32(args[1]);
                        if (Reference.MainForm.ScriptsImporter_List.Groups.Count > GroupIndex)
                        { item.Group = Reference.MainForm.ScriptsImporter_List.Groups[GroupIndex]; }
                        else
                        { item.Group = Reference.MainForm.ScriptsImporter_List.Groups[0]; }


                        Reference.MainForm.ScriptsImporter_List.Items.Add(item);
                    }
                }
            }
        }
        #endregion

    }
}
