using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Display
    {
        public static Shop CreateShop()
        {
            Shop shop = new(Display.GetShopName());
            bool isContinueCreation = true;
            do
            {
                bool addFinalCategory = Display.ChooseCategoryType();
                if (addFinalCategory)
                {
                    shop.AddCategory(new FinalCategory(Display.GetCategoryName()));
                }
                else
                {
                    shop.AddCategory(new Category(Display.GetCategoryName()));
                }

                isContinueCreation = ContinueCreation();
            } while (isContinueCreation);



            return shop;
        }


        public static string GetShopName()
        {
            string name = string.Empty;
            Console.WriteLine("Enter shop name:");
            name = Console.ReadLine();
            return name;
        }

        public static string GetCategoryName()
        {
            string name = string.Empty;
            Console.WriteLine("Enter category name:");
            name = Console.ReadLine();
            return name;
        }

        public static bool ChooseCategoryType()
        {
            Console.WriteLine("0. Add category");
            Console.WriteLine("1. Add final category");
            Console.WriteLine("Enter choice:");
            int readline = int.Parse(Console.ReadLine());
            if (readline == 0 || readline == 1)
            {
                return readline == 0 ? false : true;
            }
            else
            {
                Console.WriteLine("Incorrect value.");
                return ChooseCategoryType();
            }
        }
        public static bool ContinueCreation()
        {
            Console.WriteLine("0. Next");
            Console.WriteLine("1. Add one more");
            Console.WriteLine("Enter choice:");
            int readline = int.Parse(Console.ReadLine());
            if (readline == 0 || readline == 1)
            {
                return readline == 0 ? false : true;
            }
            else
            {
                Console.WriteLine("Incorrect value.");
                return ContinueCreation();
            }
        }


    }
}
