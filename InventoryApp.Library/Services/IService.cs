using InventoryApp.Coree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Library.Services
{
    public interface IService
    {
        List<InventoryItem> Load();
        
            
        
    }
}
