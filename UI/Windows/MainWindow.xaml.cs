using LopushokToiletPaper.UI.Pages;
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
using LopushokToiletPaper.Entities;

namespace LopushokToiletPaper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new ProductList());
            Transition.Mainframe = mainFrame;

            //var delete = Transition.Datacontext.Product.ToList();
            //foreach (var item in delete)
            //{
            //    if (item.Image!="")
            //    {
            //        item.Image = item.Image.Remove(0, 1);
            //    }
                
            //}
            //Transition.Datacontext.SaveChanges();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (Transition.Mainframe.CanGoBack)
            {
                BackBtn.Visibility = Visibility.Visible;
            }
            else
            {
                BackBtn.Visibility = Visibility.Hidden;
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Transition.Mainframe.GoBack();
        }
    }
}
