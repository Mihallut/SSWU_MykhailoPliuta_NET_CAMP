using ShopServises.Interfaces;
using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace Task_2
{
    /// <summary>
    /// Interaction logic for CommodityPage.xaml
    /// </summary>
    public partial class CommodityPage : Page
    {
        ICommodity Commodity { get; set; }
        public CommodityPage(ICommodity commodity)
        {
            InitializeComponent();
            Commodity = commodity;
            commodityName.Text = Commodity.Name;
            Type type = Commodity.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                propertiesList.Items.Add($"{property.Name} - {property.GetValue(commodity)}");
            }
        }

        private void btnCalculateShippingCost_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            double cost = mainWindow.Shop.CalculateShippingCost(Commodity);
            txtBlockResult.Text = cost.ToString();
        }
    }
}
