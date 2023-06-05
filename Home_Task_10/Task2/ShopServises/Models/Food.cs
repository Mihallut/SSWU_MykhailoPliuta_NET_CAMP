using ShopServises.Enums;
using ShopServises.Interfaces;

namespace ShopServises.Models
{
    public class Food : ICommodity
    {
        private string _name;
        private double _price;
        private double _weight;
        private bool _isPerishable;
        private Dimensions _dimension;


        public string Name { get { return new string(_name); } }

        public double Price { get { return _price; } }

        public double Weight { get { return _weight; } }

        public bool IsPerishable { get { return _isPerishable; } }

        public Dimensions Dimension { get { return _dimension; } }

        public Food(string name, double price, double weight, bool isPerishable, Dimensions dimension)
        {
            _name = new string(name);
            _price = price;
            _weight = weight;
            _isPerishable = isPerishable;
            _dimension = dimension;
        }

        public void Accept(ICalculator visitor)
        {
            visitor.CalculatePrice(this);
        }

        public object Clone()
        {
            return new Food(_name, _price, _weight, _isPerishable, _dimension);
        }
    }
}
