using MVVMApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MVVMApp.Services
{
    public class NavigationService : INavigationService
    {
        public void GoBack()
        {
            var frame = (Frame)Window.Current.Content;
            if (frame.CanGoBack)
                frame.GoBack();
        }

        public void NavigateTo(Type sourcePage)
        {
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(sourcePage);
        }

        public void NavigateTo(Type sourcePage, object parameter)
        {
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(sourcePage, parameter);
        }
    }
}
