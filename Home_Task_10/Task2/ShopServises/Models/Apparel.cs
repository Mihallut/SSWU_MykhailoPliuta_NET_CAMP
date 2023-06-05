using ShopServises.Enums;
using ShopServises.Interfaces;

namespace ShopServises.Models
{
    public class Apparel : ICommodity
    {
        private string _name;
        private double _price;
        private double _weight;
        private Dimensions _dimension;
        private ApparelSize _size;

        public string Name { get { return new string(_name); } }

        public double Price { get { return _price; } }

        public double Weight { get { return _weight; } }

        public Dimensions Dimension { get { return _dimension; } }

        public ApparelSize Size { get { return _size; } }

        public Apparel(string name, double price, double weight, Dimensions dimension, ApparelSize size)
        {
            _name = new string(name);
            _price = price;
            _weight = weight;
            _dimension = dimension;
            _size = size;
        }


        public void Accept(ICalculator visitor)
        {
            visitor.CalculatePrice(this);
        }

        public object Clone()
        {
            return new Apparel(_name, _price, _weight, _dimension, _size);
        }
    }
}
