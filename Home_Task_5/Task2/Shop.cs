using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Shop
    {
        private string _name;
        private List<ICategory> _categories;

        public List<ICategory> Categories { get { return _categories; } }
        public string Name { get { return _name; } }

        public Shop(string name)
        {
            _name = name;
            _categories = new List<ICategory>();
        }


        public void AddCategory(ICategory category)
        {
            _categories.Add(category);
        }



    }
}
