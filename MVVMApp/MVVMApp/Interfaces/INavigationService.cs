using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.Interfaces
{
    public interface INavigationService
    {
        void NavigateTo(Type Page);

        void NavigateTo(Type Page, object parameter);

        void GoBack();
    }
}
