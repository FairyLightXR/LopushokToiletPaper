using LopushokToiletPaper.Entities;
using LopushokToiletPaper.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LopushokToiletPaper.UI.Pages
{
    /// <summary>
    /// Interaction logic for ProductList.xaml
    /// </summary>
    public partial class ProductList : Page
    {

        List<Product> Product { get => Transition.Datacontext.Product.ToList(); }
        public int CountItemsProdMat { get { return Product.Count; } }

        //PageViewModel pvm = new PageViewModel(1, 0);
        public ProductList()
        {
            InitializeComponent();
            ProductLV.ItemsSource = Product;
        }

        private void TxtBoxSrch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtBoxSrch_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void TxtBoxSrch_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void CmbBoxSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbBoxFilt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ProductLV_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
