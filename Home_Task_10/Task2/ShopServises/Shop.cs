using ShopServises.Interfaces;
using ShopServises.Models;

namespace ShopServises
{
    public class Shop : IShop
    {
        private string _name;
        private ICalculator _calculator;
        private Dictionary<string, List<ICommodity>> _catalog;
        public string Name { get { return new string(_name); } }

        public ICalculator Calculator { get { return (ICalculator)_calculator.Clone(); } }

        public Dictionary<string, List<ICommodity>> Catalog
        {
            get
            {
                Dictionary<string, List<ICommodity>> temp = new Dictionary<string, List<ICommodity>>();
                foreach (var keyValuePair in _catalog)
                {
                    string key = keyValuePair.Key;
                    List<ICommodity> commodities = keyValuePair.Value;
                    List<ICommodity> tempCommodities = new List<ICommodity>();

                    foreach (ICommodity commodity in commodities)
                    {
                        tempCommodities.Add((ICommodity)commodity.Clone());
                    }
                    temp.Add(key, tempCommodities);
                }

                return temp;
            }
        }
        public Shop(string name, ICalculator calculator, Dictionary<string, List<ICommodity>> catalog)
        {
            _name = name;
            _calculator = (ICalculator)calculator.Clone();
            _catalog = new Dictionary<string, List<ICommodity>>();
            foreach (var keyValuePair in catalog)
            {
                string key = keyValuePair.Key;
                List<ICommodity> commodities = keyValuePair.Value;
                List<ICommodity> tempCommodities = new List<ICommodity>();

                foreach (ICommodity commodity in commodities)
                {
                    tempCommodities.Add((ICommodity)commodity.Clone());
                }
                _catalog.Add(key, tempCommodities);
            }
        }
        public double CalculateShippingCost(ICommodity commodity)
        {
            double cost = 0;
            if (commodity != null)
            {
                if (commodity is Electronics)
                {
                    cost = Calculator.CalculatePrice((Electronics)commodity);
                }
                else if (commodity is Food)
                {
                    cost = Calculator.CalculatePrice((Food)commodity);
                }
                else if (commodity is Apparel)
                {
                    cost = Calculator.CalculatePrice((Apparel)commodity);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else
            {
                throw new NullReferenceException();
            }

            return cost;
        }


    }
}
