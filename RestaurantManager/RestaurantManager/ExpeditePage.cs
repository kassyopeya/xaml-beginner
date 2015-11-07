using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RestaurantManager
{
    public partial class ExpeditePage 
    {
        public ExpeditePage()
        {
            InitializeComponent();
        }

        private void AppBarButton_ToMainPage(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(MainPage));
        }
    }
}
