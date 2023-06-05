using ShopServises.Models;

namespace ShopServises.Interfaces
{
    public interface ICalculator : ICloneable
    {
        public double CalculatePrice(Food product);
        public double CalculatePrice(Electronics electronics);
        public double CalculatePrice(Apparel apparel);
    }
}