using BlazorAppM.Models;
using System.Collections.Immutable;
using System.Xml.Linq;


namespace BlazorAppM.Services
{
    public class ProductService
    {
        public static readonly List<Product> Products = new List<Product>()
        {
            new()
            {
                Id = 1,
                Name = "AirPods2",
                Description="APPLE AirPods with Charging Case - White",
                Price = 119
            },
            new()
            {
                Id = 2,
                Name = "AirPods Pro",
                Description="APPLE AirPods with MagSafe Charging Case - White",
                Price = 199
            },
            new()
            {
                Id = 3,
                Name = "AirPods Max",
                Description="APPLE AirPods Max Wireless Bluetooth Noise-Cancelling  - Silver",
                Price = 549
            }
        };
    }
}
