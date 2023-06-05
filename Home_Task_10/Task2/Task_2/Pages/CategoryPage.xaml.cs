using ShopServises.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Task_2
{
    /// <summary>
    /// Interaction logic for CategoryPage.xaml
    /// </summary>
    public partial class CategoryPage : Page
    {
        List<ICommodity> Commodities { get; set; }

        public CategoryPage(string category, List<ICommodity> commodities)
        {
            InitializeComponent();
            categoryName.Text = category;
            Commodities = commodities;
            foreach (ICommodity commodiy in Commodities)
            {
                commodityList.Items.Add(commodiy.Name);
            }
        }

        private void ListBoxItem_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && sender != null)
            {
                ListBoxItem clickedItem = sender as ListBoxItem;
                if (clickedItem != null)
                {
                    string commodityName = clickedItem.Content.ToString();
                    ICommodity commodity = Commodities.FirstOrDefault(x => x.Name == commodityName);
                    MainWindow mainWindow = (MainWindow)Window.GetWindow(this);

                    mainWindow.Main.Content = new CommodityPage(commodity);
                }
            }
        }
    }
}
