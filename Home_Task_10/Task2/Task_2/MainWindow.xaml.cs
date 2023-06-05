using ShopServises;
using ShopServises.Interfaces;
using System.Windows;

namespace Task_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IShop Shop { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DemoShopInitializator demoShopInitializator = new DemoShopInitializator();
            Shop = (Shop)demoShopInitializator.InitializeShop();

            Main.Content = new CatalogPage(Shop);
        }



    }
}
