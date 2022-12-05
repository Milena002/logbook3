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
                Description="Apple AirPods with Charging Case - White",
                Price = 119,
                Photo="https://www.kfdirect.co.uk/images/thumbs/0013283_airpods-2nd-gen-with-wireless-charging-case-30-days-money-back-guarantee_510.jpeg"
            },
            new()
            {
                Id = 2,
                Name = "AirPods Pro",
                Description="Apple AirPods with MagSafe Charging Case - White",
                Price = 199,
                Photo="https://www.mobilephone4u.co.uk/images/thumbs/0013320_airpods-3rd-generation-with-wireless-magsafe-charging-case-for-apple-iphone-ipads-macbook-1-year-war_625.png"
            },
            new()
            {
                Id = 3,
                Name = "AirPods Max",
                Description="Apple AirPods Max Wireless Bluetooth Noise-Cancelling  - Silver",
                Price = 549,
                Photo="https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/airpods-max-hero-select-202011_FMT_WHH?wid=607&hei=556&fmt=jpeg&qlt=90&.v=1633623988000"
            }
        };
    }
}
