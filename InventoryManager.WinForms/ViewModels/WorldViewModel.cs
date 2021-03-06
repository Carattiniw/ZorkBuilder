﻿using InventoryManager.Data;
using System.ComponentModel;
using System;
using Newtonsoft.Json;
using System.IO;

namespace InventoryManager.WinForms.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public string Filename { get; set; }

        public BindingList<Player> Players { get; set; }

        public BindingList<Item> Items { get; set; }

        public zorkWorld World 
        { 
            set
            {
                if (mWorld  != value)
                {
                    mWorld = value;
                    if (mWorld != null)
                    {
                        Players = new BindingList<Player>(mWorld.Rooms);
                        Items = new BindingList<Item>(mWorld.Items);
                    }
                    else
                    {
                        Players = new BindingList<Player>(Array.Empty<Player>());
                        Items = new BindingList<Item>(Array.Empty<Item>());
                    }
                    
                }
            }
        }

        public WorldViewModel(zorkWorld world = null)
        {
            World = world;
        }


        public void SaveWorld()
        {
            if (string.IsNullOrEmpty(Filename))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(Filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, mWorld);
            }
        }


        public void RemoveItem(Item item)
        {
            foreach (Player player in Players)
            {
                player.Inventory.Remove(item);
            }

            Items.Remove(item);
        }


        private zorkWorld mWorld;
    }
}
