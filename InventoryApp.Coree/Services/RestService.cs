using InventoryApp.Coree.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Coree.Services
{
    public class RestService : IRepository
    {
        private RestClient _client;
        public RestService()
        {
            var options = new RestClientOptions("http://inventory.test/api/")
            {
                ThrowOnAnyError = true,
                Timeout = new TimeSpan(0,2,0)
            };
            this._client = new RestClient(options);
            this._client.AddDefaultHeaders(new Dictionary<string, string>()
            {
                {KnownHeaders.ContentType, "application/json" },
                {KnownHeaders.Accept, "application/json" },

            });
        }

        public List<InventoryItem> Load()
        {
            var request = new RestRequest("/items", Method.Get);
            var result = this._client.Get<InventoryResponse>(request);

            System.Diagnostics.Debug.WriteLine(result);
            return new List<InventoryItem>()
            {
                new InventoryItem("INV123", "Test"),
                new InventoryItem("INV343", "Probe")
            };
        }
    }
}
