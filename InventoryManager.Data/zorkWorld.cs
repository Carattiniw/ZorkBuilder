using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace InventoryManager.Data
{
    public class zorkWorld : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public List<Player> Rooms { get; set; }

        public List<Item> Items { get; set; }

        public zorkWorld()
        {
            Rooms = new List<Player>();
            Items = new List<Item>();
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            foreach (Player player in Rooms)
            {
                player.BuildInventoryFromNames(Items);
                player.BuildEquippedItemsFromNames(Items);
            }
        }
    }
}
