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
using TheseScripts.Classes.ScriptsTools;

namespace TheseScripts.Forms
{
    public partial class TheseSettings : Form
    {
        public TheseSettings()
        {
            InitializeComponent();
        }

        public void ApplySettings()
        {
            ApplyLang();
            ApplyBO3Root();

            ApplyShowConsole();
            ApplyShowBeta();
        }

        #region "Language"

        private void ApplyLang()
        {
            Langs.Translate();
        }

        private void LanguageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Langs.loadingLang)
            {
                Reference.RasuSettings.Set("lang", LanguageCombo.Text);
                ApplyLang();
            }
        }

        #endregion
        #region "BO3 Root"

        private void ApplyBO3Root()
        {
            Reference.ReloadBO3Variables();
            Reference.SettingsForm.BO3RootLinkTextBox.Text = Reference.BlackOps3Root;
        }

        private void BO3SearchFolderButton_Click(object sender, EventArgs e)
        {
            // Show message

            // Create the FolderBrowserDialog
            FolderBrowserDialog FDB = new FolderBrowserDialog();
            FDB.RootFolder = Environment.SpecialFolder.MyComputer;
            if (FDB.ShowDialog() == DialogResult.OK)
            {
                // Check if somethings is in progress
                foreach (ListViewItem item in Reference.MainForm.ScriptsImporter_List.Items)
                {
                    ScriptObject obj = (ScriptObject)item.Tag;
                    if (obj.InProgress)
                    {
                        MessageBox.Show(Langs.Operation, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }
                }

                BO3RootLinkTextBox.Text = FDB.SelectedPath;
                WriteBO3Root();
                // Reset tabpages
                Reference.MainForm.tabControl.TabPages.Clear();
            }
        }

        private void WriteBO3Root()
        {
            Reference.RasuSettings.Set("BlackOps3Root", BO3RootLinkTextBox.Text);
            ApplyBO3Root();
        }

        #endregion

        #region "Show console"

        private void ApplyShowConsole()
        {
            if (Reference.RasuSettings.Get("show_console").Equals("true", StringComparison.OrdinalIgnoreCase))
            {
                ShowConsoleCheck.Checked = true;
            }
        }

        private void ShowConsoleCheck_CheckedChanged(object sender, EventArgs e)
        {
            Reference.RasuSettings.Set("show_console", ShowConsoleCheck.Checked.ToString());
            if (Reference.MainForm.tabControl.TabPages.Contains(Reference.MainForm.tabConsole) && !ShowConsoleCheck.Checked) { Reference.MainForm.tabControl.TabPages.Remove(Reference.MainForm.tabConsole); }
            if (!Reference.MainForm.tabControl.TabPages.Contains(Reference.MainForm.tabConsole) && ShowConsoleCheck.Checked) { Reference.MainForm.tabControl.TabPages.Insert(0, Reference.MainForm.tabConsole); }
        }

        #endregion
        #region "Show beta welcome"

        private void ApplyShowBeta()
        {
            if (Reference.RasuSettings.Get("beta_welcome").Equals("true", StringComparison.OrdinalIgnoreCase))
            {
                BetaWelcomeCheck.Checked = true;
            }
        }

        private void BetaWelcomeCheck_CheckedChanged(object sender, EventArgs e)
        {
            Reference.RasuSettings.Set("beta_welcome", BetaWelcomeCheck.Checked.ToString());
        }

        #endregion

    }
}
