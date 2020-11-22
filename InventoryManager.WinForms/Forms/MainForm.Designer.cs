namespace InventoryManager.WinForms.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.playersTabPage = new System.Windows.Forms.TabPage();
            this.startingLocationLabel = new System.Windows.Forms.Label();
            this.startLocationComboBox = new System.Windows.Forms.ComboBox();
            this.equippedItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.rightHandEquippedItemControl = new InventoryManager.WinForms.Controls.EquippedItemControl();
            this.leftHandEquippedItemControl = new InventoryManager.WinForms.Controls.EquippedItemControl();
            this.feetEquippedItemControl = new InventoryManager.WinForms.Controls.EquippedItemControl();
            this.headEquippedItemControl = new InventoryManager.WinForms.Controls.EquippedItemControl();
            this.playerInventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteInventoryButton = new System.Windows.Forms.Button();
            this.addInventoryButton = new System.Windows.Forms.Button();
            this.playerInventoryListBox = new System.Windows.Forms.ListBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerHealthTextBox = new System.Windows.Forms.TextBox();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.itemWeightTextBox = new System.Windows.Forms.TextBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemWeightLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.playersTabPage.SuspendLayout();
            this.equippedItemsGroupBox.SuspendLayout();
            this.playerInventoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.itemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(InventoryManager.WinForms.ViewModels.WorldViewModel);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.playersTabPage);
            this.mainTabControl.Controls.Add(this.itemsTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(12, 40);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1183, 952);
            this.mainTabControl.TabIndex = 3;
            // 
            // playersTabPage
            // 
            this.playersTabPage.Controls.Add(this.startingLocationLabel);
            this.playersTabPage.Controls.Add(this.startLocationComboBox);
            this.playersTabPage.Controls.Add(this.equippedItemsGroupBox);
            this.playersTabPage.Controls.Add(this.playerInventoryGroupBox);
            this.playersTabPage.Controls.Add(this.playerHealthTextBox);
            this.playersTabPage.Controls.Add(this.playerHealthLabel);
            this.playersTabPage.Controls.Add(this.playerNameTextBox);
            this.playersTabPage.Controls.Add(this.playerNameLabel);
            this.playersTabPage.Controls.Add(this.deletePlayerButton);
            this.playersTabPage.Controls.Add(this.addPlayerButton);
            this.playersTabPage.Controls.Add(this.playersListBox);
            this.playersTabPage.Location = new System.Drawing.Point(4, 25);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.playersTabPage.Size = new System.Drawing.Size(1175, 923);
            this.playersTabPage.TabIndex = 0;
            this.playersTabPage.Text = "World";
            this.playersTabPage.UseVisualStyleBackColor = true;
            // 
            // startingLocationLabel
            // 
            this.startingLocationLabel.AutoSize = true;
            this.startingLocationLabel.Location = new System.Drawing.Point(312, 6);
            this.startingLocationLabel.Name = "startingLocationLabel";
            this.startingLocationLabel.Size = new System.Drawing.Size(119, 17);
            this.startingLocationLabel.TabIndex = 12;
            this.startingLocationLabel.Text = "Starting Location:";
            // 
            // startLocationComboBox
            // 
            this.startLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startLocationComboBox.FormattingEnabled = true;
            this.startLocationComboBox.Location = new System.Drawing.Point(312, 26);
            this.startLocationComboBox.Name = "startLocationComboBox";
            this.startLocationComboBox.Size = new System.Drawing.Size(230, 24);
            this.startLocationComboBox.TabIndex = 11;
            // 
            // equippedItemsGroupBox
            // 
            this.equippedItemsGroupBox.Controls.Add(this.rightHandEquippedItemControl);
            this.equippedItemsGroupBox.Controls.Add(this.leftHandEquippedItemControl);
            this.equippedItemsGroupBox.Controls.Add(this.feetEquippedItemControl);
            this.equippedItemsGroupBox.Controls.Add(this.headEquippedItemControl);
            this.equippedItemsGroupBox.Location = new System.Drawing.Point(312, 148);
            this.equippedItemsGroupBox.Name = "equippedItemsGroupBox";
            this.equippedItemsGroupBox.Size = new System.Drawing.Size(857, 366);
            this.equippedItemsGroupBox.TabIndex = 10;
            this.equippedItemsGroupBox.TabStop = false;
            this.equippedItemsGroupBox.Text = "Current Neighbors";
            // 
            // rightHandEquippedItemControl
            // 
            this.rightHandEquippedItemControl.EquipLocation = InventoryManager.Data.EquipLocations.East;
            this.rightHandEquippedItemControl.EquippedItem = null;
            this.rightHandEquippedItemControl.Location = new System.Drawing.Point(500, 156);
            this.rightHandEquippedItemControl.Name = "rightHandEquippedItemControl";
            this.rightHandEquippedItemControl.Player = null;
            this.rightHandEquippedItemControl.Size = new System.Drawing.Size(351, 63);
            this.rightHandEquippedItemControl.TabIndex = 3;
            // 
            // leftHandEquippedItemControl
            // 
            this.leftHandEquippedItemControl.EquipLocation = InventoryManager.Data.EquipLocations.West;
            this.leftHandEquippedItemControl.EquippedItem = null;
            this.leftHandEquippedItemControl.Location = new System.Drawing.Point(6, 156);
            this.leftHandEquippedItemControl.Name = "leftHandEquippedItemControl";
            this.leftHandEquippedItemControl.Player = null;
            this.leftHandEquippedItemControl.Size = new System.Drawing.Size(351, 63);
            this.leftHandEquippedItemControl.TabIndex = 2;
            // 
            // feetEquippedItemControl
            // 
            this.feetEquippedItemControl.EquipLocation = InventoryManager.Data.EquipLocations.South;
            this.feetEquippedItemControl.EquippedItem = null;
            this.feetEquippedItemControl.Location = new System.Drawing.Point(241, 297);
            this.feetEquippedItemControl.Name = "feetEquippedItemControl";
            this.feetEquippedItemControl.Player = null;
            this.feetEquippedItemControl.Size = new System.Drawing.Size(351, 63);
            this.feetEquippedItemControl.TabIndex = 1;
            // 
            // headEquippedItemControl
            // 
            this.headEquippedItemControl.EquipLocation = InventoryManager.Data.EquipLocations.North;
            this.headEquippedItemControl.EquippedItem = null;
            this.headEquippedItemControl.Location = new System.Drawing.Point(241, 12);
            this.headEquippedItemControl.Name = "headEquippedItemControl";
            this.headEquippedItemControl.Player = null;
            this.headEquippedItemControl.Size = new System.Drawing.Size(351, 63);
            this.headEquippedItemControl.TabIndex = 0;
            // 
            // playerInventoryGroupBox
            // 
            this.playerInventoryGroupBox.Controls.Add(this.deleteInventoryButton);
            this.playerInventoryGroupBox.Controls.Add(this.addInventoryButton);
            this.playerInventoryGroupBox.Controls.Add(this.playerInventoryListBox);
            this.playerInventoryGroupBox.Location = new System.Drawing.Point(313, 520);
            this.playerInventoryGroupBox.Name = "playerInventoryGroupBox";
            this.playerInventoryGroupBox.Size = new System.Drawing.Size(389, 338);
            this.playerInventoryGroupBox.TabIndex = 9;
            this.playerInventoryGroupBox.TabStop = false;
            this.playerInventoryGroupBox.Text = "Available Neighbors";
            // 
            // deleteInventoryButton
            // 
            this.deleteInventoryButton.Location = new System.Drawing.Point(87, 309);
            this.deleteInventoryButton.Name = "deleteInventoryButton";
            this.deleteInventoryButton.Size = new System.Drawing.Size(75, 23);
            this.deleteInventoryButton.TabIndex = 4;
            this.deleteInventoryButton.Text = "&Delete";
            this.deleteInventoryButton.UseVisualStyleBackColor = true;
            this.deleteInventoryButton.Click += new System.EventHandler(this.DeleteInventoryButton_Click);
            // 
            // addInventoryButton
            // 
            this.addInventoryButton.Location = new System.Drawing.Point(6, 309);
            this.addInventoryButton.Name = "addInventoryButton";
            this.addInventoryButton.Size = new System.Drawing.Size(75, 23);
            this.addInventoryButton.TabIndex = 3;
            this.addInventoryButton.Text = "&Add...";
            this.addInventoryButton.UseVisualStyleBackColor = true;
            this.addInventoryButton.Click += new System.EventHandler(this.AddInventoryButton_Click);
            // 
            // playerInventoryListBox
            // 
            this.playerInventoryListBox.DataSource = this.inventoryBindingSource;
            this.playerInventoryListBox.DisplayMember = "Name";
            this.playerInventoryListBox.FormattingEnabled = true;
            this.playerInventoryListBox.ItemHeight = 16;
            this.playerInventoryListBox.Location = new System.Drawing.Point(7, 22);
            this.playerInventoryListBox.Name = "playerInventoryListBox";
            this.playerInventoryListBox.Size = new System.Drawing.Size(376, 276);
            this.playerInventoryListBox.TabIndex = 0;
            this.playerInventoryListBox.ValueMember = "Name";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.playersBindingSource;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // playerHealthTextBox
            // 
            this.playerHealthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Description", true));
            this.playerHealthTextBox.Location = new System.Drawing.Point(312, 120);
            this.playerHealthTextBox.Name = "playerHealthTextBox";
            this.playerHealthTextBox.Size = new System.Drawing.Size(848, 22);
            this.playerHealthTextBox.TabIndex = 6;
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.Location = new System.Drawing.Point(309, 99);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(83, 17);
            this.playerHealthLabel.TabIndex = 5;
            this.playerHealthLabel.Text = "&Description:";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerNameTextBox.Location = new System.Drawing.Point(313, 74);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(229, 22);
            this.playerNameTextBox.TabIndex = 4;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(310, 53);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(49, 17);
            this.playerNameLabel.TabIndex = 3;
            this.playerNameLabel.Text = "&Name:";
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.Location = new System.Drawing.Point(87, 864);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(75, 23);
            this.deletePlayerButton.TabIndex = 2;
            this.deletePlayerButton.Text = "&Delete";
            this.deletePlayerButton.UseVisualStyleBackColor = true;
            this.deletePlayerButton.Click += new System.EventHandler(this.DeletePlayerButton_Click);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(6, 864);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.addPlayerButton.TabIndex = 1;
            this.addPlayerButton.Text = "&Add...";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // playersListBox
            // 
            this.playersListBox.DataSource = this.playersBindingSource;
            this.playersListBox.DisplayMember = "Name";
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.ItemHeight = 16;
            this.playersListBox.Location = new System.Drawing.Point(6, 6);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(300, 852);
            this.playersListBox.TabIndex = 0;
            this.playersListBox.ValueMember = "Health";
            this.playersListBox.SelectedIndexChanged += new System.EventHandler(this.PlayersListBox_SelectedIndexChanged);
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemWeightTextBox);
            this.itemsTabPage.Controls.Add(this.itemWeightLabel);
            this.itemsTabPage.Controls.Add(this.itemNameTextBox);
            this.itemsTabPage.Controls.Add(this.itemNameLabel);
            this.itemsTabPage.Controls.Add(this.deleteItemButton);
            this.itemsTabPage.Controls.Add(this.addItemButton);
            this.itemsTabPage.Controls.Add(this.itemsListBox);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 25);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(1175, 923);
            this.itemsTabPage.TabIndex = 1;
            this.itemsTabPage.Text = "Game";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemWeightTextBox
            // 
            this.itemWeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Weight", true));
            this.itemWeightTextBox.Location = new System.Drawing.Point(314, 73);
            this.itemWeightTextBox.Name = "itemWeightTextBox";
            this.itemWeightTextBox.Size = new System.Drawing.Size(119, 22);
            this.itemWeightTextBox.TabIndex = 10;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // itemWeightLabel
            // 
            this.itemWeightLabel.AutoSize = true;
            this.itemWeightLabel.Location = new System.Drawing.Point(311, 52);
            this.itemWeightLabel.Name = "itemWeightLabel";
            this.itemWeightLabel.Size = new System.Drawing.Size(56, 17);
            this.itemWeightLabel.TabIndex = 9;
            this.itemWeightLabel.Text = "&Weight:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Name", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(315, 27);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(386, 22);
            this.itemNameTextBox.TabIndex = 8;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(312, 6);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(49, 17);
            this.itemNameLabel.TabIndex = 7;
            this.itemNameLabel.Text = "&Name:";
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(87, 864);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(75, 23);
            this.deleteItemButton.TabIndex = 4;
            this.deleteItemButton.Text = "&Delete";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(6, 864);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 3;
            this.addItemButton.Text = "&Add...";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.DataSource = this.itemsBindingSource;
            this.itemsListBox.DisplayMember = "Name";
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 16;
            this.itemsListBox.Location = new System.Drawing.Point(6, 6);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(300, 852);
            this.itemsListBox.TabIndex = 1;
            this.itemsListBox.ValueMember = "Name";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1207, 28);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorldToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.openWorldToolStripMenuItem.Text = "&Open World...";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.OpenWorldToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "World files (*.json)|*.json";
            this.saveFileDialog.Title = "Save world file";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 1004);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.playersTabPage.ResumeLayout(false);
            this.playersTabPage.PerformLayout();
            this.equippedItemsGroupBox.ResumeLayout(false);
            this.playerInventoryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.itemsTabPage.ResumeLayout(false);
            this.itemsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage playersTabPage;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.Button deletePlayerButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.TextBox playerHealthTextBox;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox playerInventoryGroupBox;
        private System.Windows.Forms.Button deleteInventoryButton;
        private System.Windows.Forms.Button addInventoryButton;
        private System.Windows.Forms.ListBox playerInventoryListBox;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.TextBox itemWeightTextBox;
        private System.Windows.Forms.Label itemWeightLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.GroupBox equippedItemsGroupBox;
        private Controls.EquippedItemControl rightHandEquippedItemControl;
        private Controls.EquippedItemControl leftHandEquippedItemControl;
        private Controls.EquippedItemControl feetEquippedItemControl;
        private Controls.EquippedItemControl headEquippedItemControl;
        private System.Windows.Forms.Label startingLocationLabel;
        private System.Windows.Forms.ComboBox startLocationComboBox;
    }
}

