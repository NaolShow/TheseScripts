using TheseScripts.Classes;

namespace TheseScripts
{
    partial class TheseScripts
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("GSC Scripts", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("GSH Scripts", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("CSC Scripts", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Other", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Not categorized", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Powerup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Bosses", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Perks", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Visual", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Weapons", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Zombies maps", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("Multiplayers Maps", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheseScripts));
            this.ToolBar = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openUsermapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.synchronizeMapFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTheWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMapInformations = new System.Windows.Forms.TabPage();
            this.MapInformations_List = new System.Windows.Forms.ListView();
            this.MapInformations_FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MapInformations_FilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MapInformations_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openTheFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTheFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabScriptsImporter = new System.Windows.Forms.TabPage();
            this.ScriptsImporter_LocalImport = new System.Windows.Forms.Button();
            this.ScriptsImporter_List = new System.Windows.Forms.ListView();
            this.ScriptsImporter_ScriptName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScriptsImporter_Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScriptsImporter_Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScriptsImporter_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScriptsImporter_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTheOriginalLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabOpenUserMap = new System.Windows.Forms.TabPage();
            this.OpenUsermap_List = new System.Windows.Forms.ListView();
            this.OpenUsermap_SelectMap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OpenUsermap_OK = new System.Windows.Forms.Button();
            this.OpenUsermap_Cancel = new System.Windows.Forms.Button();
            this.tabConsole = new System.Windows.Forms.TabPage();
            this.Console = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.discordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMapInformations.SuspendLayout();
            this.MapInformations_Menu.SuspendLayout();
            this.tabScriptsImporter.SuspendLayout();
            this.ScriptsImporter_Menu.SuspendLayout();
            this.tabOpenUserMap.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(704, 24);
            this.ToolBar.TabIndex = 0;
            this.ToolBar.Tag = "main";
            this.ToolBar.Text = "ToolBar";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openUsermapToolStripMenuItem,
            this.toolStripSeparator1,
            this.synchronizeMapFilesToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // openUsermapToolStripMenuItem
            // 
            this.openUsermapToolStripMenuItem.Name = "openUsermapToolStripMenuItem";
            this.openUsermapToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.openUsermapToolStripMenuItem.Text = "Open usermap";
            this.openUsermapToolStripMenuItem.Click += new System.EventHandler(this.openUsermapToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // synchronizeMapFilesToolStripMenuItem
            // 
            this.synchronizeMapFilesToolStripMenuItem.Name = "synchronizeMapFilesToolStripMenuItem";
            this.synchronizeMapFilesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.synchronizeMapFilesToolStripMenuItem.Text = "Synchronize map files";
            this.synchronizeMapFilesToolStripMenuItem.Click += new System.EventHandler(this.synchronizeMapFilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTheWikiToolStripMenuItem,
            this.discordToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openTheWikiToolStripMenuItem
            // 
            this.openTheWikiToolStripMenuItem.Name = "openTheWikiToolStripMenuItem";
            this.openTheWikiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openTheWikiToolStripMenuItem.Text = "Open the wiki";
            this.openTheWikiToolStripMenuItem.Click += new System.EventHandler(this.openTheWikiToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMapInformations);
            this.tabControl.Controls.Add(this.tabScriptsImporter);
            this.tabControl.Controls.Add(this.tabOpenUserMap);
            this.tabControl.Controls.Add(this.tabConsole);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(704, 417);
            this.tabControl.TabIndex = 1;
            // 
            // tabMapInformations
            // 
            this.tabMapInformations.Controls.Add(this.MapInformations_List);
            this.tabMapInformations.Location = new System.Drawing.Point(4, 22);
            this.tabMapInformations.Name = "tabMapInformations";
            this.tabMapInformations.Padding = new System.Windows.Forms.Padding(3);
            this.tabMapInformations.Size = new System.Drawing.Size(696, 391);
            this.tabMapInformations.TabIndex = 0;
            this.tabMapInformations.Text = "Map informations";
            this.tabMapInformations.UseVisualStyleBackColor = true;
            // 
            // MapInformations_List
            // 
            this.MapInformations_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MapInformations_FileName,
            this.MapInformations_FilePath});
            this.MapInformations_List.ContextMenuStrip = this.MapInformations_Menu;
            this.MapInformations_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapInformations_List.FullRowSelect = true;
            listViewGroup1.Header = "GSC Scripts";
            listViewGroup1.Name = ".gsc";
            listViewGroup2.Header = "GSH Scripts";
            listViewGroup2.Name = ".gsh";
            listViewGroup3.Header = "CSC Scripts";
            listViewGroup3.Name = ".csc";
            listViewGroup4.Header = "Other";
            listViewGroup4.Name = "other";
            this.MapInformations_List.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.MapInformations_List.Location = new System.Drawing.Point(3, 3);
            this.MapInformations_List.Name = "MapInformations_List";
            this.MapInformations_List.Size = new System.Drawing.Size(690, 385);
            this.MapInformations_List.TabIndex = 0;
            this.MapInformations_List.UseCompatibleStateImageBehavior = false;
            this.MapInformations_List.View = System.Windows.Forms.View.Details;
            // 
            // MapInformations_FileName
            // 
            this.MapInformations_FileName.Text = "File name";
            this.MapInformations_FileName.Width = 265;
            // 
            // MapInformations_FilePath
            // 
            this.MapInformations_FilePath.Text = "File path";
            this.MapInformations_FilePath.Width = 1000;
            // 
            // MapInformations_Menu
            // 
            this.MapInformations_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTheFileLocationToolStripMenuItem,
            this.openTheFileToolStripMenuItem,
            this.deleteFileToolStripMenuItem});
            this.MapInformations_Menu.Name = "MapInformations_Menu";
            this.MapInformations_Menu.Size = new System.Drawing.Size(189, 70);
            this.MapInformations_Menu.Opening += new System.ComponentModel.CancelEventHandler(this.MapInformations_Menu_Opening);
            // 
            // openTheFileLocationToolStripMenuItem
            // 
            this.openTheFileLocationToolStripMenuItem.Name = "openTheFileLocationToolStripMenuItem";
            this.openTheFileLocationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openTheFileLocationToolStripMenuItem.Text = "Open the file location";
            this.openTheFileLocationToolStripMenuItem.Click += new System.EventHandler(this.openTheFileLocationToolStripMenuItem_Click);
            // 
            // openTheFileToolStripMenuItem
            // 
            this.openTheFileToolStripMenuItem.Name = "openTheFileToolStripMenuItem";
            this.openTheFileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openTheFileToolStripMenuItem.Text = "Open the file";
            this.openTheFileToolStripMenuItem.Click += new System.EventHandler(this.openTheFileToolStripMenuItem_Click);
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.deleteFileToolStripMenuItem.Text = "Delete file";
            this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // tabScriptsImporter
            // 
            this.tabScriptsImporter.Controls.Add(this.ScriptsImporter_LocalImport);
            this.tabScriptsImporter.Controls.Add(this.ScriptsImporter_List);
            this.tabScriptsImporter.Location = new System.Drawing.Point(4, 22);
            this.tabScriptsImporter.Name = "tabScriptsImporter";
            this.tabScriptsImporter.Padding = new System.Windows.Forms.Padding(3);
            this.tabScriptsImporter.Size = new System.Drawing.Size(696, 391);
            this.tabScriptsImporter.TabIndex = 1;
            this.tabScriptsImporter.Text = "Scripts Importer";
            this.tabScriptsImporter.UseVisualStyleBackColor = true;
            // 
            // ScriptsImporter_LocalImport
            // 
            this.ScriptsImporter_LocalImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptsImporter_LocalImport.Location = new System.Drawing.Point(8, 362);
            this.ScriptsImporter_LocalImport.Name = "ScriptsImporter_LocalImport";
            this.ScriptsImporter_LocalImport.Size = new System.Drawing.Size(680, 23);
            this.ScriptsImporter_LocalImport.TabIndex = 1;
            this.ScriptsImporter_LocalImport.Text = "Import local script package";
            this.ScriptsImporter_LocalImport.UseVisualStyleBackColor = true;
            this.ScriptsImporter_LocalImport.Click += new System.EventHandler(this.ScriptsImporter_LocalImport_Click);
            // 
            // ScriptsImporter_List
            // 
            this.ScriptsImporter_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptsImporter_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ScriptsImporter_ScriptName,
            this.ScriptsImporter_Author,
            this.ScriptsImporter_Version,
            this.ScriptsImporter_Status});
            this.ScriptsImporter_List.ContextMenuStrip = this.ScriptsImporter_Menu;
            this.ScriptsImporter_List.FullRowSelect = true;
            listViewGroup5.Header = "Not categorized";
            listViewGroup5.Name = "ScriptsImporter_NotCategorized";
            listViewGroup6.Header = "Powerup";
            listViewGroup6.Name = "ScriptsImporter_Powerup";
            listViewGroup7.Header = "Bosses";
            listViewGroup7.Name = "ScriptsImporter_Boss";
            listViewGroup8.Header = "Perks";
            listViewGroup8.Name = "ScriptsImporter_Perks";
            listViewGroup9.Header = "Visual";
            listViewGroup9.Name = "ScriptsImporter_Visual";
            listViewGroup10.Header = "Weapons";
            listViewGroup10.Name = "ScriptsImporter_Weapons";
            this.ScriptsImporter_List.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10});
            this.ScriptsImporter_List.Location = new System.Drawing.Point(3, 3);
            this.ScriptsImporter_List.Name = "ScriptsImporter_List";
            this.ScriptsImporter_List.Size = new System.Drawing.Size(690, 353);
            this.ScriptsImporter_List.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ScriptsImporter_List.TabIndex = 0;
            this.ScriptsImporter_List.UseCompatibleStateImageBehavior = false;
            this.ScriptsImporter_List.View = System.Windows.Forms.View.Details;
            // 
            // ScriptsImporter_ScriptName
            // 
            this.ScriptsImporter_ScriptName.Text = "Script name";
            this.ScriptsImporter_ScriptName.Width = 203;
            // 
            // ScriptsImporter_Author
            // 
            this.ScriptsImporter_Author.Text = "Author";
            this.ScriptsImporter_Author.Width = 191;
            // 
            // ScriptsImporter_Version
            // 
            this.ScriptsImporter_Version.Text = "Version";
            this.ScriptsImporter_Version.Width = 143;
            // 
            // ScriptsImporter_Status
            // 
            this.ScriptsImporter_Status.Text = "Status";
            this.ScriptsImporter_Status.Width = 148;
            // 
            // ScriptsImporter_Menu
            // 
            this.ScriptsImporter_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importScriptToolStripMenuItem,
            this.openTheOriginalLinkToolStripMenuItem});
            this.ScriptsImporter_Menu.Name = "ScriptsImporter_Menu";
            this.ScriptsImporter_Menu.Size = new System.Drawing.Size(189, 48);
            this.ScriptsImporter_Menu.Opening += new System.ComponentModel.CancelEventHandler(this.ScriptsImporter_Menu_Opening);
            // 
            // importScriptToolStripMenuItem
            // 
            this.importScriptToolStripMenuItem.Name = "importScriptToolStripMenuItem";
            this.importScriptToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.importScriptToolStripMenuItem.Text = "Import the script";
            this.importScriptToolStripMenuItem.Click += new System.EventHandler(this.importScriptToolStripMenuItem_Click);
            // 
            // openTheOriginalLinkToolStripMenuItem
            // 
            this.openTheOriginalLinkToolStripMenuItem.Name = "openTheOriginalLinkToolStripMenuItem";
            this.openTheOriginalLinkToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openTheOriginalLinkToolStripMenuItem.Text = "Open the original link";
            this.openTheOriginalLinkToolStripMenuItem.Click += new System.EventHandler(this.openTheOriginalLinkToolStripMenuItem_Click);
            // 
            // tabOpenUserMap
            // 
            this.tabOpenUserMap.Controls.Add(this.OpenUsermap_List);
            this.tabOpenUserMap.Controls.Add(this.tableLayoutPanel1);
            this.tabOpenUserMap.Location = new System.Drawing.Point(4, 22);
            this.tabOpenUserMap.Name = "tabOpenUserMap";
            this.tabOpenUserMap.Size = new System.Drawing.Size(696, 391);
            this.tabOpenUserMap.TabIndex = 2;
            this.tabOpenUserMap.Text = "Open a user map";
            this.tabOpenUserMap.UseVisualStyleBackColor = true;
            // 
            // OpenUsermap_List
            // 
            this.OpenUsermap_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenUsermap_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OpenUsermap_SelectMap});
            this.OpenUsermap_List.FullRowSelect = true;
            listViewGroup11.Header = "Zombies maps";
            listViewGroup11.Name = "OpenUsermap_ZombiesMaps";
            listViewGroup12.Header = "Multiplayers Maps";
            listViewGroup12.Name = "OpenUsermap_MultiplayersMaps";
            this.OpenUsermap_List.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup11,
            listViewGroup12});
            this.OpenUsermap_List.Location = new System.Drawing.Point(14, 14);
            this.OpenUsermap_List.MultiSelect = false;
            this.OpenUsermap_List.Name = "OpenUsermap_List";
            this.OpenUsermap_List.Size = new System.Drawing.Size(671, 332);
            this.OpenUsermap_List.TabIndex = 5;
            this.OpenUsermap_List.UseCompatibleStateImageBehavior = false;
            this.OpenUsermap_List.View = System.Windows.Forms.View.Details;
            this.OpenUsermap_List.DoubleClick += new System.EventHandler(this.OpenUsermap_List_DoubleClick);
            // 
            // OpenUsermap_SelectMap
            // 
            this.OpenUsermap_SelectMap.Text = "Select one of your maps below:";
            this.OpenUsermap_SelectMap.Width = 660;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.OpenUsermap_OK, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OpenUsermap_Cancel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 352);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(671, 31);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // OpenUsermap_OK
            // 
            this.OpenUsermap_OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenUsermap_OK.Location = new System.Drawing.Point(3, 3);
            this.OpenUsermap_OK.Name = "OpenUsermap_OK";
            this.OpenUsermap_OK.Size = new System.Drawing.Size(329, 23);
            this.OpenUsermap_OK.TabIndex = 3;
            this.OpenUsermap_OK.Text = "OK";
            this.OpenUsermap_OK.UseVisualStyleBackColor = true;
            this.OpenUsermap_OK.Click += new System.EventHandler(this.OKOpenUserMapButton_Click);
            // 
            // OpenUsermap_Cancel
            // 
            this.OpenUsermap_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenUsermap_Cancel.Location = new System.Drawing.Point(338, 3);
            this.OpenUsermap_Cancel.Name = "OpenUsermap_Cancel";
            this.OpenUsermap_Cancel.Size = new System.Drawing.Size(330, 23);
            this.OpenUsermap_Cancel.TabIndex = 2;
            this.OpenUsermap_Cancel.Text = "Cancel";
            this.OpenUsermap_Cancel.UseVisualStyleBackColor = true;
            this.OpenUsermap_Cancel.Click += new System.EventHandler(this.CancelOpenUserMapButton_Click);
            // 
            // tabConsole
            // 
            this.tabConsole.Controls.Add(this.Console);
            this.tabConsole.Location = new System.Drawing.Point(4, 22);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsole.Size = new System.Drawing.Size(696, 391);
            this.tabConsole.TabIndex = 4;
            this.tabConsole.Text = "Console";
            this.tabConsole.UseVisualStyleBackColor = true;
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.Color.DarkGray;
            this.Console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Console.ForeColor = System.Drawing.Color.White;
            this.Console.Location = new System.Drawing.Point(3, 3);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(690, 385);
            this.Console.TabIndex = 0;
            this.Console.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "rar";
            this.openFileDialog.Filter = "Script package|*.rar";
            this.openFileDialog.Title = "Choose a Script Package";
            // 
            // discordToolStripMenuItem
            // 
            this.discordToolStripMenuItem.Name = "discordToolStripMenuItem";
            this.discordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.discordToolStripMenuItem.Text = "Discord";
            this.discordToolStripMenuItem.Click += new System.EventHandler(this.discordToolStripMenuItem_Click);
            // 
            // TheseScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ToolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ToolBar;
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "TheseScripts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheseScripts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TheseScripts_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TheseScripts_FormClosed);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabMapInformations.ResumeLayout(false);
            this.MapInformations_Menu.ResumeLayout(false);
            this.tabScriptsImporter.ResumeLayout(false);
            this.ScriptsImporter_Menu.ResumeLayout(false);
            this.tabOpenUserMap.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabConsole.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip ToolBar;
        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TabPage tabMapInformations;
        public System.Windows.Forms.TabPage tabScriptsImporter;
        public System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem openUsermapToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem synchronizeMapFilesToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.TabPage tabOpenUserMap;
        public System.Windows.Forms.Button OpenUsermap_Cancel;
        public System.Windows.Forms.Button OpenUsermap_OK;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ListView OpenUsermap_List;
        public System.Windows.Forms.ColumnHeader OpenUsermap_SelectMap;
        public System.Windows.Forms.ListView MapInformations_List;
        public System.Windows.Forms.ColumnHeader MapInformations_FileName;
        public System.Windows.Forms.ColumnHeader MapInformations_FilePath;
        public System.Windows.Forms.ContextMenuStrip MapInformations_Menu;
        public System.Windows.Forms.ToolStripMenuItem openTheFileLocationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem openTheFileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
        public System.Windows.Forms.ListView ScriptsImporter_List;
        public System.Windows.Forms.ColumnHeader ScriptsImporter_ScriptName;
        public System.Windows.Forms.ColumnHeader ScriptsImporter_Author;
        public System.Windows.Forms.ColumnHeader ScriptsImporter_Version;
        public System.Windows.Forms.ContextMenuStrip ScriptsImporter_Menu;
        public System.Windows.Forms.ToolStripMenuItem importScriptToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem openTheOriginalLinkToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.Button ScriptsImporter_LocalImport;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.ColumnHeader ScriptsImporter_Status;
        public System.Windows.Forms.TabPage tabConsole;
        public System.Windows.Forms.RichTextBox Console;
        public System.Windows.Forms.ToolStripMenuItem openTheWikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discordToolStripMenuItem;
    }
}

