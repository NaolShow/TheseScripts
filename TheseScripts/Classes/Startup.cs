using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheseScripts.Forms;
using TheseScripts.Properties;
using WolfLib;

namespace TheseScripts.Classes
{
    public static class Startup
    {

        public static void Start()
        {
            // Process Verification (Check if the software is not running twice)
            String thisprocessname = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            if (System.Diagnostics.Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
            {
                MessageBox.Show(Langs.DoubleProcess, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            // Iniatialize folders
            Folders();
            // Iniatialize files
            Files();

            // Initialize variables (part 1/2)
            Reference.RasuSettings = new Rasu(Reference.SettingsFile);

            // Updates
            Updates.UpdateFiles();

            // Initialize variables (part 2/2)
            Reference.RasuScripts = new Rasu(Reference.ScriptsFile);
            Reference.ReloadBO3Variables();
            Reference.SettingsForm = new TheseSettings();
            Reference.MainForm = new TheseScripts();

            // Hide tabcontrol pages
            Reference.MainForm.tabControl.TabPages.Clear();

            // Iniatialize settings
            Reference.SettingsForm.ApplySettings();

            // Show MainForm
            Reference.MainForm.Show();
            Reference.SplashForm.Hide();

            // Update
            Updates.Update();

            // Show beta welcome
            if (Reference.RasuSettings.Get("beta_welcome").Equals("true", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(Langs.BetaWelcome, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void Folders()
        {
            // Retrieve all directories who need to be created
            String[] paths = { Reference.MainPath, Reference.SettingsPath, Reference.ScriptsPath, Reference.TempPath };
            // Create them
            foreach (String path in paths)
            {
                if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            }
        }

        public static void Files()
        {
            // Creating and filling the settings file (if it does not exist)
            if (!File.Exists(Reference.SettingsFile))
            {
                File.Create(Reference.SettingsFile).Dispose();
                File.WriteAllText(Reference.SettingsFile, Resources.settings);
            }

            if (!File.Exists(Reference.ScriptsFile))
            {
                File.Create(Reference.ScriptsFile).Dispose();
            }

            // Creating and filling langs files
            File.Create(Reference.SettingsPath + "English.lang").Dispose();
            File.WriteAllText(Reference.SettingsPath + "English.lang", Resources.English);
            File.WriteAllText(Reference.SettingsPath + "Français.lang", Resources.Français);
            File.WriteAllText(Reference.SettingsPath + "Deutsch.lang", Resources.Deutsch);
            File.WriteAllText(Reference.SettingsPath + "Español.lang", Resources.Español);
            File.WriteAllText(Reference.SettingsPath + "Italiano.lang", Resources.Italiano);
        }
    }
}
