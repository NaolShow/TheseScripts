using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfLib;

namespace TheseScripts.Classes
{
    public static class Langs
    {

        // Langs variables
        public static String WrongBO3Root;
        public static String NeedRestart;
        public static String PleaseSelectMap;
        public static String NoConnection;
        public static String Operation;
        public static String Update;

        public static String DoubleProcess;
        public static String BetaWelcome;

        public static String DeleteFiles;

        public static String Downloading;
        public static String Importing;
        public static String Completed;

        // This variable allows the software not to crash when translated
        public static bool loadingLang = false;
        public static void Translate()
        {
            loadingLang = true;

            // Implements the list of installed software languages in a list
            Reference.SettingsForm.LanguageCombo.Items.Clear();
            foreach (String lang in Directory.GetFiles(Reference.SettingsPath, "*.lang", SearchOption.TopDirectoryOnly))
            {
                Reference.SettingsForm.LanguageCombo.Items.Add(Path.GetFileNameWithoutExtension(lang));
            }

            // If the language specified in the settings does not exist, the software will load the English language
            if (!File.Exists(Reference.SettingsPath + Reference.RasuSettings.Get("lang") + ".lang")) { Reference.RasuSettings.Set("lang", "English"); }
            // Selects the language specified in the settings
            Reference.SettingsForm.LanguageCombo.SelectedIndex = Reference.SettingsForm.LanguageCombo.FindStringExact(Reference.RasuSettings.Get("lang"));
            // Load the contents of the language file into a RASU variable
            Rasu Lang = new Rasu(Reference.SettingsPath + Reference.RasuSettings.Get("lang") + ".lang");

            #region "Main window"

            Update = Lang.Get("update");

            Operation = Lang.Get("operation");

            DoubleProcess = Lang.Get("double_process");
            BetaWelcome = Lang.Get("beta_welcome");

            #region "ToolBar"

            // Files
            Reference.MainForm.filesToolStripMenuItem.Text = Lang.Get("files");
            Reference.MainForm.openUsermapToolStripMenuItem.Text = Lang.Get("open_usermap");
            Reference.MainForm.synchronizeMapFilesToolStripMenuItem.Text = Lang.Get("synchronize_map_files");
            Reference.MainForm.settingsToolStripMenuItem.Text = Lang.Get("settings");

            // Help
            Reference.MainForm.helpToolStripMenuItem.Text = Lang.Get("help");
            Reference.MainForm.openTheWikiToolStripMenuItem.Text = Lang.Get("open_wiki");

            #endregion

            #region "Tabpages"

            Reference.MainForm.tabMapInformations.Text = Lang.Get("map_informations");
            Reference.MainForm.tabScriptsImporter.Text = Lang.Get("scripts_importer");
            Reference.MainForm.tabOpenUserMap.Text = Lang.Get("open_usermap");

            #endregion

            #region "tabOpenUserMap"

            WrongBO3Root = Lang.Get("wrong_bo3_root");
            Reference.MainForm.OpenUsermap_SelectMap.Text = Lang.Get("select_map");
            PleaseSelectMap = Lang.Get("please_select_map");
            Reference.MainForm.OpenUsermap_Cancel.Text = Lang.Get("cancel");
            Reference.MainForm.OpenUsermap_OK.Text = Lang.Get("ok");

            Reference.MainForm.OpenUsermap_List.Groups[0].Header = Lang.Get("zombies_maps");
            Reference.MainForm.OpenUsermap_List.Groups[1].Header = Lang.Get("multiplayers_maps");

            #endregion

            #region "tabMapInformations"

            Reference.MainForm.MapInformations_FileName.Text = Lang.Get("file_name");
            Reference.MainForm.MapInformations_FilePath.Text = Lang.Get("file_path");

            Reference.MainForm.openTheFileLocationToolStripMenuItem.Text = Lang.Get("open_file_location");
            Reference.MainForm.openTheFileToolStripMenuItem.Text = Lang.Get("open_file");
            Reference.MainForm.deleteFileToolStripMenuItem.Text = Lang.Get("delete_file");

            DeleteFiles = Lang.Get("delete_files");

            #endregion

            #region "tabScriptsImporter"

            NoConnection = Lang.Get("no_connection");
            Reference.MainForm.ScriptsImporter_LocalImport.Text = Lang.Get("import_local_script_package");

            Reference.MainForm.openFileDialog.Title = Lang.Get("choose_script_package");

            Reference.MainForm.importScriptToolStripMenuItem.Text = Lang.Get("import_script");
            Reference.MainForm.openTheOriginalLinkToolStripMenuItem.Text = Lang.Get("open_original_link");

            Reference.MainForm.ScriptsImporter_ScriptName.Text = Lang.Get("script_name");
            Reference.MainForm.ScriptsImporter_Author.Text = Lang.Get("script_author");
            Reference.MainForm.ScriptsImporter_Version.Text = Lang.Get("script_version");

            Reference.MainForm.ScriptsImporter_Status.Text = Lang.Get("script_status");
            Downloading = Lang.Get("downloading");
            Importing = Lang.Get("importing");
            Completed = Lang.Get("completed");

            Reference.MainForm.ScriptsImporter_List.Groups[0].Header = Lang.Get("not_categorized");
            Reference.MainForm.ScriptsImporter_List.Groups[1].Header = Lang.Get("powerups");
            Reference.MainForm.ScriptsImporter_List.Groups[2].Header = Lang.Get("bosses");
            Reference.MainForm.ScriptsImporter_List.Groups[3].Header = Lang.Get("perks");
            Reference.MainForm.ScriptsImporter_List.Groups[4].Header = Lang.Get("visual");
            Reference.MainForm.ScriptsImporter_List.Groups[5].Header = Lang.Get("weapons");

            #endregion

            #endregion

            #region "Settings window"

            NeedRestart = Lang.Get("needrestart");

            #region "General"

            Reference.SettingsForm.tabGeneral.Text = Lang.Get("general");

            Reference.SettingsForm.LanguageLabel.Text = Lang.Get("language") + ":";
            Reference.SettingsForm.BO3RootLabel.Text = Lang.Get("bo3_root") + ":";

            // Miscellaneous

            Reference.SettingsForm.MiscellaneousGroupBox.Text = Lang.Get("miscellaneous");
            Reference.SettingsForm.BetaWelcomeCheck.Text = Lang.Get("show_beta_message");

            #endregion

            #region "Advanced"

            Reference.SettingsForm.tabAdvanced.Text = Lang.Get("advanced");

            Reference.SettingsForm.TabsGroupBox.Text = Lang.Get("pages");
            Reference.SettingsForm.ShowConsoleCheck.Text = Lang.Get("show_console");

            #endregion

            #endregion

            loadingLang = false;
        }

    }
}
