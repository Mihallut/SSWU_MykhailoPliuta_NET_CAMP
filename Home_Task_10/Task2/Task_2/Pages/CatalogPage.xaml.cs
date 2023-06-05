using ShopServises.Interfaces;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Task_2
{
    /// <summary>
    /// Interaction logic for CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        IShop Shop { get; set; }
        public CatalogPage(IShop shop)
        {
            InitializeComponent();
            Shop = shop;
            shopName.Text = Shop.Name;
            foreach (string category in Shop.Catalog.Keys)
            {
                categoryList.Items.Add(category);
            }

        }
        private void ListBoxItem_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                ListBoxItem clickedItem = sender as ListBoxItem;
                string key = clickedItem.Content.ToString();
                if (key != null)
                {
                    List<ICommodity> commodities = Shop.Catalog[key];
                    MainWindow mainWindow = (MainWindow)Window.GetWindow(this);

                    mainWindow.Main.Content = new CategoryPage(key, commodities);

                }
            }
        }
    }
}
