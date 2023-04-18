using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Category : ICategory
    {
        private string _name;
        private List<ICategory> _subcategories;

        public string Name { get { return _name; } }
        public List<ICategory> Subcategories { get { return _subcategories; } }


        public Category(string name)
        {
            _name = name;
            _subcategories = new List<ICategory>();
        }


        public void AddCategory(ICategory category)
        {
            _subcategories.Add(category);
        }
    }
}
