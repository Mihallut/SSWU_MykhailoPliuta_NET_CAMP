using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Box : IPackable
    {
        private readonly string _name;
        private readonly double _width;
        private readonly double _height;
        private readonly double _length;
        private Stack<IPackable> _packed;

        public string Name { get { return _name; } }

        public double Width { get { return _width; } }

        public double Height { get { return _height; } }

        public double Length { get { return _length; } }

        public Stack<IPackable> Packed { get { return _packed; } }

        public Box(Product product)
        {
            _name = product.Name;
            _width = product.Width;
            _height = product.Height;
            _length = product.Width;
        }

        public Box(string name, params Box[] packedSubcategories)
        {
            _length = packedSubcategories.Max(a => a.Length);
            _width = packedSubcategories.Max(a => a.Width);
            _height = packedSubcategories.Max(a => a.Height);

            _packed = new Stack<IPackable>();
            foreach (var subcategory in packedSubcategories)
            {
                _packed.Push(subcategory);
            }

        }
    }
}
