using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Product : IPackable
    {
        private readonly string _name;
        private readonly double _width;
        private readonly double _height;
        private readonly double _length;

        public string Name { get { return _name; } }

        public double Width { get { return _width; } }

        public double Height { get { return _height; } }

        public double Length { get { return _length; } }

        public Product(string name, double width, double height, double length)
        {
            _name = name;
            _width = width;
            _height = height;
            _length = length;
        }
    }
}
