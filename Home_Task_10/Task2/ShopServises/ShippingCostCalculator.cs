using ShopServises.Interfaces;
using ShopServises.Models;

namespace ShopServises
{
    public class ShippingCostCalculator : ICalculator, ICloneable
    {
        public double PerishableSurcharge;
        public double DimensionSurcharge;

        public ShippingCostCalculator(double perishableSurcharge, double dimensionSurcharge)
        {
            PerishableSurcharge = perishableSurcharge;
            DimensionSurcharge = dimensionSurcharge;
        }
        public double CalculatePrice(Food product)
        {
            double shippingCost = product.Price * product.Weight + ((double)product.Dimension * 0.1) * product.Weight;
            if (product.IsPerishable)
            {
                shippingCost += PerishableSurcharge * product.Weight;
            }

            return shippingCost;
        }

        public double CalculatePrice(Electronics electronics)
        {
            double shippingCost = electronics.Price + electronics.Weight * ((double)electronics.Dimension);
            if (electronics.Dimension > Enums.Dimensions.M)
            {
                shippingCost += electronics.Price * DimensionSurcharge * 0.01;
            }
            return shippingCost;
        }

        public double CalculatePrice(Apparel apparel)
        {
            return apparel.Price + ((apparel.Weight * (double)apparel.Dimension) * 100);

        }

        public object Clone()
        {
            return new ShippingCostCalculator(PerishableSurcharge, DimensionSurcharge);
        }
    }
}
