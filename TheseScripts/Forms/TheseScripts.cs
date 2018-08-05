using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheseScripts.Classes;
using TheseScripts.Classes.ScriptsTools;
using TheseScripts.Forms;

namespace TheseScripts
{
    public partial class TheseScripts : Form
    {
        public TheseScripts()
        {
            InitializeComponent();
        }

        /*
         *  TheseScripts
         * 
         *  Made by NaolShow
         *  Published on GitHub,ToWolf.livehost.fr
         * 
         *  ToWolf.livehost.fr - Development WebSite
         * 
         *  15 years old, French developer
         * 
         */

        #region "Event code of menu items"

        /* 
         *  Files menu items
         */

        // Open the tabOpenUsermap page
        private void openUsermapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if somethings is in progress
            foreach (ListViewItem item in ScriptsImporter_List.Items)
            {
                ScriptObject obj = (ScriptObject)item.Tag;
                if (obj.InProgress)
                {
                    MessageBox.Show(Langs.Operation, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            // Removes the tabs
            Utils.ClearTabs();
            // Open the page to load another map
            tabControl.TabPages.Insert(tabControl.TabPages.Count, tabOpenUserMap);
            Reference.MainForm.tabControl.SelectedTab = tabOpenUserMap;

            // Clear list
            OpenUsermap_List.Items.Clear();
            // Check if the specified folder of the game is correct
            if (!File.Exists(Reference.BO3_Exe))
            {
                MessageBox.Show(Langs.WrongBO3Root, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Load the user's maps into a list
            foreach (String folder in Directory.GetDirectories(Reference.BO3_usermaps))
            {
                // Create the item that will be implemented in the list
                ListViewItem item = new ListViewItem(Path.GetFileName(folder));

                // Look what type of map, and assign it to the right group
                // If a map that does not start with "zm" or "mp" is present in the folder, it will not be displayed
                if (Path.GetFileName(folder).Substring(0, 2) == "zm") { item.Group = OpenUsermap_List.Groups[0]; }
                else if (Path.GetFileName(folder).Substring(0, 2) == "mp") { item.Group = OpenUsermap_List.Groups[1]; }
                // Implements the item in the list
                OpenUsermap_List.Items.Add(item);
            }
        }

        // Reload the information of the map
        public void synchronizeMapFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a map is loaded
            if (this.Text != Application.ProductName)
            {
                Utils.LoadMapInformations();
            }
            else { MessageBox.Show(Langs.PleaseSelectMap, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // Open the settings window
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reference.SettingsForm.ShowDialog();
        }

        /* 
         *  Help menu items
         */

        private void openTheWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/NaolShow/TheseScripts/wiki");
        }

        private void discordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.me/towolf");
        }

        #endregion

        #region "Code of the page "tabOpenUserMap""

        // Load the selected map
        private void OKOpenUserMapButton_Click(object sender, EventArgs e)
        {
            if (OpenUsermap_List.SelectedItems.Count > 0)
            {
                Utils.SelectMap(OpenUsermap_List.SelectedItems[0].Text);
            }
            else { MessageBox.Show(Langs.PleaseSelectMap, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // Double click to open the map
        private void OpenUsermap_List_DoubleClick(object sender, EventArgs e)
        {
            OpenUsermap_OK.PerformClick();
        }

        // Remove the page that is used to load a map
        private void CancelOpenUserMapButton_Click(object sender, EventArgs e)
        {
            Utils.ClearTabs();
        }

        #endregion
        #region "Code of the page "tabMapInformations""

        // Activation of the menu, if an object is selected
        private void MapInformations_Menu_Opening(object sender, CancelEventArgs e)
        {
            if (MapInformations_List.SelectedItems.Count > 0) { MapInformations_Menu.Enabled = true; } else { MapInformations_Menu.Enabled = false; }
        }

        // Open the file location
        private void openTheFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MapInformations_List.SelectedItems) { System.Diagnostics.Process.Start(Path.GetDirectoryName(item.SubItems[1].Text)); }
        }

        // Open the file
        private void openTheFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MapInformations_List.SelectedItems) { System.Diagnostics.Process.Start(item.SubItems[1].Text); }
        }

        // Delete the file
        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(Langs.DeleteFiles, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    foreach (ListViewItem item in MapInformations_List.SelectedItems) { File.Delete(item.SubItems[1].Text); }
                    synchronizeMapFilesToolStripMenuItem_Click(this, new EventArgs());
                }
            }
            catch (Exception ex) { Utils.ThrowException(ex); }
        }

        #endregion
        #region "Code of the page "tabScriptsImporter""

        // Activation of the menu, if an object is selected
        private void ScriptsImporter_Menu_Opening(object sender, CancelEventArgs e)
        {
            if (ScriptsImporter_List.SelectedItems.Count > 0) { ScriptsImporter_Menu.Enabled = true; } else { ScriptsImporter_Menu.Enabled = false; }
        }

        // Download and import the script
        private void importScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ScriptsImporter_List.SelectedItems)
            {
                ScriptObject obj = (ScriptObject)item.Tag;
                obj.DownloadPackage();
            }
        }

        // Open the original link
        private void openTheOriginalLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ScriptsImporter_List.SelectedItems)
            {
                ScriptObject obj = (ScriptObject)item.Tag;
                System.Diagnostics.Process.Start(obj.author_link);
            }
            
        }

        // Import local script
        private void ScriptsImporter_LocalImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ScriptObject localScript = new ScriptObject(new String[] 
                {
                    "NO",
                    "0",
                    Path.GetFileNameWithoutExtension(openFileDialog.FileName),
                    "NO",
                    "NO",
                    "NO",
                    "NO"
                });
                localScript.path = openFileDialog.FileName;
                localScript.ImportPackage();
            }
        }

        #endregion

        private void TheseScripts_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Back up software settings
            Reference.RasuSettings.SaveFile();
            Reference.RasuScripts.SaveFile();
        }

        private void TheseScripts_FormClosed(object sender, FormClosedEventArgs e)
        {
            // This is mandatory for me. Otherwise the SplashScreen window is not closed and the program remains in the background.
            Environment.Exit(0);
        }
    }
}
