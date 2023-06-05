namespace ShopServises.Interfaces
{
    public interface IShop
    {
        public string Name { get; }
        public ICalculator Calculator { get; }
        public Dictionary<string, List<ICommodity>> Catalog { get; }

        public double CalculateShippingCost(ICommodity commodity);

    }
}
