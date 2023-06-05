using ShopServises.Enums;

namespace ShopServises.Interfaces
{
    public interface ICommodity : ICloneable
    {
        public string Name { get; }

        public double Price { get; }

        public double Weight { get; }

        public Dimensions Dimension { get; }

        public void Accept(ICalculator visitor);

    }
}
