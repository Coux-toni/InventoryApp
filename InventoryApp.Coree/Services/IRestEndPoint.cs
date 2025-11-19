using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Coree.Services
{
    public interface IRestEndPoint
    {
        void SetEndPoint(string api, string token);
    }
}
