using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class FinalCategory : ICategory
    {
        private string _name;
        private List<Product> _products;

        public string Name { get { return _name; } }
        public List<Product> Products { get { return _products; } }


        public FinalCategory(string name)
        {
            _name = name;
        }
    }
}
