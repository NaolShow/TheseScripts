using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheseScripts.Forms;
using WolfLib;

namespace TheseScripts.Classes
{
    public static class Reference
    {

        // Variables
        public static String MainPath = Application.StartupPath + "\\";
        public static String ScriptsPath = MainPath + "Scripts\\";
        public static String SettingsPath = MainPath + "Settings\\";
        public static String TempPath = MainPath + "Temp\\";
        public static String SettingsFile = SettingsPath + "settings.settings";
        public static String ScriptsFile = ScriptsPath + "scripts.versions";

        // Rasu variables (For people who look at the code "RASU" comes from a C# library called WolfLib that I created)
        public static Rasu RasuSettings;
        public static Rasu RasuScripts;

        // Forms
        public static TheseScripts MainForm;
        public static TheseSettings SettingsForm;
        public static SplashScreen SplashForm;

        // [GLOBAL] Black ops 3 references
        public static String BlackOps3Root;
        public static String BO3_usermaps;
        public static String BO3_Exe;

        // Files that should not be overwritten when installing a script
        public static List<String> Overwrite = new List<String>();
        public static void ReloadBO3Variables()
        {
            try
            {
                BlackOps3Root = RasuSettings.Get("BlackOps3Root");
                BO3_usermaps = BlackOps3Root + "\\usermaps\\";
                BO3_Exe = BlackOps3Root + "\\BlackOps3.exe";
            }
            catch (Exception ex) { Utils.ThrowException(ex); }
        }

        // [MAPS] Black ops 3 references
        public static String MAP_name;
        public static String MAP_type;
        public static String MAP_path;

        public static String[] MAP_extensions = {".gsc", ".gsh", ".csc"};
        public static String[] MAP_otherextensions = {".zone", ".csv"};
        public static String[] ReferencedMapPath = {"\\scripts\\" + MAP_type + "\\",
                                                    "\\sound\\zoneconfig\\",
                                                    "\\gamedata\\"};

        public static void ReloadMAPVariables(String mapName)
        {
            MAP_name = mapName;
            MAP_type = mapName.Substring(0, 2);
            MAP_path = BO3_usermaps + mapName;

            // Files that should not be overwritten when installing a script
            Overwrite.Add(BlackOps3Root + @"\share\raw\sound\aliases\user_aliases.csv");
            foreach (String file in Directory.GetFiles(Reference.MAP_path, "*.*", SearchOption.AllDirectories))
            {
                Overwrite.Add(file);
            }
        }
    }
}
