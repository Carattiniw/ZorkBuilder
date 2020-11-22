using System.IO;
using System;
using System.Windows.Forms;
using InventoryManager.Data;
using Newtonsoft.Json;
using InventoryManager.WinForms.ViewModels;
using InventoryManager.WinForms.Forms;
using InventoryManager.WinForms.Controls;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace InventoryManager.WinForms.Forms
{
    public partial class MainForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
        
        private WorldViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }
            }
        }

        private bool IsWorldLoaded
        {
            get => mIsWorldLoaded;
            set
            {
                mIsWorldLoaded = value;
                mainTabControl.Enabled = mIsWorldLoaded;
                saveToolStripMenuItem.Enabled = mIsWorldLoaded;
                saveAsToolStripMenuItem.Enabled = mIsWorldLoaded;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsWorldLoaded = false;

            mEquipItemControlMap = new Dictionary<EquipLocations, EquippedItemControl>
            {
                { EquipLocations.West, leftHandEquippedItemControl },
                { EquipLocations.East, rightHandEquippedItemControl },
                { EquipLocations.North, headEquippedItemControl },
                { EquipLocations.South, feetEquippedItemControl }
            };
        }


        private void AddPlayerButton_Click(object sender, System.EventArgs e)
        {
            using (AddPlayerForm addPlayerForm = new AddPlayerForm())
            {
                if (addPlayerForm.ShowDialog() == DialogResult.OK)
                {
                    Player player = new Player { Name = addPlayerForm.PlayerName };
                    ViewModel.Players.Add(player);
                }
            }
        }


        private void PlayersListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            deletePlayerButton.Enabled = playersListBox.SelectedItem != null;
            Player selectedPlayer = playersListBox.SelectedItem as Player;
            foreach (var control in mEquipItemControlMap.Values)
            {
                control.Player = selectedPlayer;
            }
        }

        private void DeletePlayerButton_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Delete this player?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Players.Remove((Player)playersListBox.SelectedItem);
                playersListBox.SelectedItem = ViewModel.Players.FirstOrDefault();
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            using (AddItemForm addItemForm = new AddItemForm())
            {
                if (addItemForm.ShowDialog() == DialogResult.OK)
                {
                    Item item = new Item { Name = addItemForm.ItemName };
                    ViewModel.Items.Add(item);
                }
            }
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this item?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.RemoveItem((Item)itemsListBox.SelectedItem);
                itemsListBox.SelectedItem = ViewModel.Items.FirstOrDefault();
            }
        }

        private void AddInventoryButton_Click(object sender, EventArgs e) => ShowNotYetImplementedMessageBox();

        private void DeleteInventoryButton_Click(object sender, EventArgs e)
        {
            ShowNotYetImplementedMessageBox();

            //if (MessageBox.Show("Delete this item?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    ViewModel.RemoveItem((Item)playerInventoryListBox.SelectedItem);
            //    playerInventoryListBox.SelectedItem = ViewModel.Items.FirstOrDefault();
            //}
        }


        private void ShowNotYetImplementedMessageBox() => MessageBox.Show("Not yet implemented.", AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        

        #region Main Menu
        private void OpenWorldToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<zorkWorld>(File.ReadAllText(openFileDialog.FileName));
                //ViewModel.World.Rooms = JsonConvert.DeserializeObject<zorkWorld>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;

                Player selectedPlayer = playersListBox.SelectedItem as Player;
                foreach (var control in mEquipItemControlMap.Values)
                {
                    control.Player = selectedPlayer;
                }

                IsWorldLoaded = true;
            }
        }


        private void SaveToolStripMenuItem_Click(object sender, System.EventArgs e) => ViewModel.SaveWorld();

        private void SaveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e) => Close();
        #endregion


        private WorldViewModel mViewModel;
        private bool mIsWorldLoaded;
        private readonly Dictionary<EquipLocations, EquippedItemControl> mEquipItemControlMap;
        //private readonly Dictionary<Rooms, EquippedItemControl> mEquipItemControlMap;
    }
}
