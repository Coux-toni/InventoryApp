using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InventoryApp.Coree.Models
{
    public class InventoryItem
    {
        
        public long Id { get; set; } = 0;
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("inventory_number")]
        public string InventoryNumber { get; set; }


        public InventoryItem(string inventoryNumber, string title)
        {
            
            this.InventoryNumber = inventoryNumber;
            this.Title = title;
        }
    }
}
