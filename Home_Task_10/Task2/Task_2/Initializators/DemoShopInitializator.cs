using ShopServises;
using ShopServises.Enums;
using ShopServises.Interfaces;
using ShopServises.Models;
using System.Collections.Generic;
using Task_2.Initializators;

namespace Task_2
{
    internal class DemoShopInitializator : IShopInitializator
    {
        public IShop InitializeShop()
        {
            Dictionary<string, List<ICommodity>> demoCatalog = new Dictionary<string, List<ICommodity>>();
            List<ICommodity> electronics = new List<ICommodity>() {
                        new Electronics("Multicooker", 2456.54, 3.075, Dimensions.L),
                        new Electronics("TV", 6999, 3.5, Dimensions.L),
                        new Electronics("Laptop", 36999, 2.3, Dimensions.M),
                        new Electronics("Fridge", 9856, 49, Dimensions.XXXL)
            };
            demoCatalog.Add("Electronics", electronics);


            List<ICommodity> apparels = new List<ICommodity>()
            {
                new Apparel("T-shirt", 1450, 0.3, Dimensions.S, ApparelSize.M),
                new Apparel("Dress", 2300, 0.4, Dimensions.S, ApparelSize.M),
            };
            demoCatalog.Add("Apparel", apparels);

            List<ICommodity> food = new List<ICommodity>()
            {
                new Food("Apple", 36, 1.5, false, Dimensions.M),
                new Food("Сottage cheese", 57, 0.5, true, Dimensions.S),
                new Food("Sausage", 299, 1, false, Dimensions.M)
            };
            demoCatalog.Add("Food", food);

            ShippingCostCalculator shippingCostCalculator = new ShippingCostCalculator(5.5, 15.3);

            return new Shop("Demo Shop", shippingCostCalculator, demoCatalog);
        }
    }
}
