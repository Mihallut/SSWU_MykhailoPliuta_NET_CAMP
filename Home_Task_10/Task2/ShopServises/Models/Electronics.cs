using ShopServises.Enums;
using ShopServises.Interfaces;

namespace ShopServises.Models
{
    public class Electronics : ICommodity
    {
        private string _name;
        private double _price;
        private double _weight;
        private Dimensions _dimension;


        public string Name { get { return new string(_name); } }

        public double Price { get { return _price; } }

        public double Weight { get { return _weight; } }

        public Dimensions Dimension { get { return _dimension; } }

        public Electronics(string name, double price, double weight, Dimensions dimension)
        {
            _name = new string(name);
            _price = price;
            _weight = weight;
            _dimension = dimension;
        }

        public void Accept(ICalculator visitor)
        {
            visitor.CalculatePrice(this);
        }

        public object Clone()
        {

            return new Electronics(_name, _price, _weight, _dimension);

        }
    }
}
