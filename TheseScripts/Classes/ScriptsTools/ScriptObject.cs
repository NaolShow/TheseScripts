using SharpCompress.Archives;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheseScripts.Classes.ScriptsTools
{
    public class ScriptObject
    {

        public String name { get; set; }
        public String author { get; set; }
        public String version { get; set; }
        public String download_link { get; set; }
        public String author_link { get; set; }
        public String path { get; set; }

        public Boolean InProgress { get; set; }
        private WebClient downloader { get; set; }

        public ScriptObject(String[] args)
        {
            this.name = args[2];
            this.author = args[3];
            this.version = args[4];
            this.download_link = args[5];
            this.author_link = args[6];
            this.path = Reference.ScriptsPath + this.name + ".rar";
            this.Cooldown = false;
        }

        #region "Visual control"

        private void ChangeStatus(String Status)
        {
            // Check if the script package is not local
            if (Reference.MainForm.ScriptsImporter_List.FindItemWithText(this.name) != null)
            {
                Reference.MainForm.ScriptsImporter_List.FindItemWithText(this.name).SubItems[3].Text = Status;
            }
        }

        #endregion

        #region "Download script package"

        public void DownloadPackage()
        {
            if (!this.InProgress)
            {
                try
                {
                    Utils.WriteConsole(String.Format("[Scripts importer] ({0}) Beginning of the download and installation of the script", this.name));
                    InProgress = true;
                    // Check if the file has been already downloaded one time
                    if (File.Exists(Reference.ScriptsPath + this.name + ".rar"))
                    {
                        // Check if the file version don't equals with this.version
                        if (Reference.RasuScripts.Get(this.name) == this.version)
                        {
                            this.ImportPackage();
                            return;
                        }
                    }
                }
                catch (Exception ex) { Utils.ThrowException(ex); }
                try
                {
                    // Download the package
                    downloader = new WebClient();
                    downloader.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    downloader.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    downloader.DownloadFileAsync(new Uri(this.download_link), Reference.ScriptsPath + this.name + ".rar", true);
                }
                // A message is sent if the user does not have an internet connection
                catch { MessageBox.Show(Langs.NoConnection, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); downloader.CancelAsync(); }
            }
        }

        private Boolean Cooldown { get; set; }
        private async void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (!this.Cooldown && Reference.MainForm.ScriptsImporter_List.FindItemWithText(this.name).SubItems[3].Text != Langs.Completed)
            {
                // Prevent spamming the console
                this.Cooldown = true;
                await Task.Delay(1000);

                ChangeStatus(String.Format("{0} ({1}%)", Langs.Downloading, e.ProgressPercentage));
                Utils.WriteConsole(String.Format("[Scripts importer] ({0}) Downloading the script ({1}%)", this.name, e.ProgressPercentage));

                this.Cooldown = false;
            }
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    Utils.WriteConsole(String.Format("[Scripts importer] ({0}) The script download has been canceled", this.name));
                }
                else
                {
                    Utils.WriteConsole(String.Format("[Scripts importer] ({0}) The script download is complete", this.name));

                    // Write the new version
                    if (Reference.RasuScripts.Check(this.name)) { Reference.RasuScripts.Set(this.name, this.version); }
                    else { WolfLib.Files.InsertLine(Reference.RasuScripts.GetFilePath(), this.name + ": " + this.version, File.ReadAllLines(Reference.RasuScripts.GetFilePath()).Count()); Reference.RasuScripts.ReloadFile(); }
                    this.ImportPackage();
                }
            }
            catch (Exception ex) { Utils.ThrowException(ex); }
        }

#endregion

        public async void ImportPackage()
        {
            try
            {
                Utils.WriteConsole(String.Format("[Scripts importer] ({0}) Extracting the script package", this.name));
                ChangeStatus(Langs.Importing);

                // Extract the .rar in temp folder
                if (Directory.Exists(Reference.TempPath + this.name)) { Directory.Delete(Reference.TempPath + this.name, true); }
                var archive = ArchiveFactory.Open(this.path);
                archive.WriteToDirectory(Reference.TempPath + this.name, new ExtractionOptions() { ExtractFullPath = true, Overwrite = true });
                archive.Dispose();

                // Import the package
                foreach (String path in Directory.GetFiles(Reference.TempPath + this.name, "*.*", SearchOption.AllDirectories))
                {
                    // Get relative path
                    String RelativePath = path.Substring(Reference.TempPath.Length + this.name.Length);
                    RelativePath = RelativePath.Replace("{usermap}", Reference.MAP_name);
                    String FinalPath = Reference.BlackOps3Root + RelativePath;

                    // Check if the folder or file exists, existing files can be overwritten
                    if (!Directory.Exists(Path.GetDirectoryName(FinalPath))) { Directory.CreateDirectory(Path.GetDirectoryName(FinalPath)); }
                    if (!Reference.Overwrite.Contains(FinalPath)) { File.Copy(path, FinalPath, true); Utils.WriteConsole(String.Format("[Scripts importer] ({0}) A file has been overwritten ({1})", this.name, FinalPath)); }
                    else
                    {
                        // Import script code
                        String[] ComplexFile = new String[] { ".gsc", ".csc" };
                        if (ComplexFile.Contains(Path.GetExtension(FinalPath))) { ImportComplexFile(FinalPath, path); }
                        else
                        {
                            String FinalPathContent = File.ReadAllText(FinalPath).Trim();
                            Boolean AlreadyImported = true;
                            // Check if the code has not already been imported. (To avoid duplicates)
                            foreach (String codeLine in File.ReadAllText(path).Trim().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None))
                            {
                                if (!FinalPathContent.Contains(codeLine)) { WolfLib.Files.InsertLine(FinalPath, codeLine, File.ReadAllLines(FinalPath).Count()); AlreadyImported = false; }
                            }
                            if (AlreadyImported) { Utils.WriteConsole(String.Format("[Scripts importer] ({0}) The code has already been imported ({1})", this.name, FinalPath)); }
                        }
                    }
                }

                // Delete the temp folder
                if (Directory.Exists(Reference.TempPath + this.name)) { Directory.Delete(Reference.TempPath + this.name, true); }

                Utils.WriteConsole(String.Format("[Scripts importer] ({0}) The script package has been successfully imported", this.name));
                Reference.ReloadMAPVariables(Reference.MAP_name);

                // Change the status of the script to "Completed" 
                await Task.Delay(1000);
                ChangeStatus(Langs.Completed);
                InProgress = false;
            }
            catch (Exception ex) { Utils.ThrowException(ex); }
        }

        #region "Import script functions"

        private void InsertFunction(String FinalPath, String TagArgs, String Code)
        {
            try
            {
                // Splitted tag args
                String[] Args = TagArgs.Split(',').Select(p => p.Trim()).ToArray();

                // Does not import code, if the tag has no function defined
                if (Args.Count() > 0)
                {
                    // If the position parameter indicates "up" the Up variable will be true. 
                    // Otherwise (if the argument of the position does not exist or it is not valid) 
                    // the variable Up will be false
                    Boolean Up = false;
                    if (Args.Count() > 1) { if (Args[1].Equals("up", StringComparison.OrdinalIgnoreCase)) { Up = true; } }

                    // Read all lines
                    int i = 0;
                    Boolean functionReached = false;
                    foreach (String line in File.ReadAllLines(FinalPath))
                    {
                        if (line.StartsWith("function " + Args[0])) { functionReached = true; }
                        if (line.Contains("{") && Up && functionReached) { WolfLib.Files.InsertLine(FinalPath, Code, i+1); break; }
                        if (line.Contains("}") && !Up && functionReached) { WolfLib.Files.InsertLine(FinalPath, Code, i--); break; }
                        i++;
                    }
                }
            }
            catch (Exception ex) { Utils.ThrowException(ex); }
        }

        private void ImportCode(String FinalPath, String Code, String TagType, String TagArgs)
        {
            try
            {
                String ImportCode = Code.Trim();
                if (!File.ReadAllText(FinalPath).Trim().Contains(ImportCode))
                {
                    // Verification for orphan tags
                    if (TagType.Equals("using", StringComparison.OrdinalIgnoreCase))
                    {
                        WolfLib.Files.InsertLine(FinalPath, ImportCode, 0);
                    }
                    else if (TagType.Equals("body", StringComparison.OrdinalIgnoreCase))
                    {
                        WolfLib.Files.InsertLine(FinalPath, ImportCode, File.ReadAllLines(FinalPath).Count());
                    }
                    // Tags with arguments
                    else if (TagType.Equals("function", StringComparison.OrdinalIgnoreCase))
                    {
                        InsertFunction(FinalPath, TagArgs, ImportCode);
                    }
                }
            }
            catch (Exception ex) { Utils.ThrowException(ex); }
        }

        // Complex file = *.gsc, *.csc
        private void ImportComplexFile(String FinalPath, String SourcePath)
        {
            try
            {
                // Tags variables
                String OpenTagType = null;
                String OpenTagArgs = null;
                // Tags code
                StringBuilder BetweenTags = new StringBuilder();

                // Read all lines
                int i = 0;
                foreach (String SourceContentLine in File.ReadAllLines(SourcePath))
                {
                    String line = SourceContentLine.Trim();

                    // Check if the line is a tag (open)
                    if (line.StartsWith("[") && line.EndsWith("]"))
                    {
                        if (!line.Contains("/"))
                        {
                            // Get tag informations
                            OpenTagType = Regex.Match(line, @"\[(.*?)\]").Groups[1].Value.Split('(')[0];
                            OpenTagArgs = Regex.Match(line, @"\[.*?\((.*?)\)\]").Groups[1].Value;
                        }
                        // This is launched when we have the position of the tags
                        if (line.Contains("/" + OpenTagType))
                        {
                            // Import code
                            ImportCode(FinalPath, BetweenTags.ToString(), OpenTagType, OpenTagArgs);
                            // Reset the variables
                            BetweenTags.Clear();
                            OpenTagType = null;
                        }
                    }
                    else if (OpenTagType != null)
                    {
                        // This is the text who is between two tags
                        BetweenTags.AppendLine(line);
                    }
                    i++;
                }
            }
            catch (Exception ex) { Utils.ThrowException(ex); }
        }
        #endregion
    }
}
