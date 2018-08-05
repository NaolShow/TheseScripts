using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheseScripts.Classes.ScriptsTools;

namespace TheseScripts.Classes
{
    public static class Utils
    {

        // This function allows me to collect errors.
        public static void ThrowException(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

        public static void WriteConsole(String Text)
        {
            Reference.MainForm.Console.AppendText(Text + Environment.NewLine);
            // Scroll at the very bottom of the console
            Reference.MainForm.Console.SelectionStart = Reference.MainForm.Console.Text.Length;
            Reference.MainForm.Console.ScrollToCaret();
        }

        // Reset the page display to zero (keep the help page if it was already open)
        public static void ClearTabs()
        {
            Boolean Console = false;
            if (Reference.MainForm.tabControl.TabPages.Contains(Reference.MainForm.tabConsole)) { Console = true; }
            Reference.MainForm.tabControl.TabPages.Clear();
            if (Console) { Reference.MainForm.tabControl.TabPages.Insert(99, Reference.MainForm.tabConsole); }
        }

        // Select a map
        public static void SelectMap(String mapName)
        {
            // Removes the tabs
            Utils.ClearTabs();

            // Display map name in the title
            Reference.MainForm.Text = Application.ProductName + " - " + mapName;

            // Load map informations
            Reference.ReloadMAPVariables(mapName);
            Reference.MainForm.synchronizeMapFilesToolStripMenuItem_Click(Reference.MainForm, new EventArgs());
            ScriptsDownloader.RetrieveScriptsList();

            // Open tabpages
            Reference.MainForm.tabControl.TabPages.Insert(Reference.MainForm.tabControl.TabCount, Reference.MainForm.tabMapInformations);
            Reference.MainForm.tabControl.TabPages.Insert(Reference.MainForm.tabControl.TabCount, Reference.MainForm.tabScriptsImporter);
        }

        // Load map information that is used
        public static void LoadMapInformations()
        {
            try
            {
                // Load informations (tabMapInformations)
                Reference.MainForm.MapInformations_List.Items.Clear();
                foreach (String ReferencedPath in Reference.ReferencedMapPath)
                {
                    if (!Directory.Exists(Reference.MAP_path + ReferencedPath)) { Directory.CreateDirectory(Reference.MAP_path + ReferencedPath); }
                    foreach (String script in Directory.GetFiles(Reference.MAP_path + ReferencedPath, "*.*", SearchOption.AllDirectories))
                    {
                        RegisterMapFile(script);
                    }
                }
                RegisterMapFile(Reference.MAP_path + "\\zone_source\\" + Reference.MAP_name + ".zone");
            }
            catch (Exception ex) { Utils.ThrowException(ex); }
        }

        // Register map files
        private static void RegisterMapFile(String scriptPath)
        {
            ListViewItem item = new ListViewItem(Path.GetFileName(scriptPath));
            item.SubItems.Add(scriptPath);

            // Check file extension, and places in a group
            String ext = Path.GetExtension(scriptPath);
            if (Reference.MAP_extensions.Contains(ext)) { item.Group = Reference.MainForm.MapInformations_List.Groups[ext]; }
            else if (Reference.MAP_otherextensions.Contains(ext)) { item.Group = Reference.MainForm.MapInformations_List.Groups["other"]; }

            // Does not display the file if it should not be
            if (item.Group != null) { Reference.MainForm.MapInformations_List.Items.Add(item); }
        }

    }

}
