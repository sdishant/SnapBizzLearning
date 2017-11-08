using MVVMApp.Services;
using MVVMApp.ViewModel;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MVVMApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            this.InitializeComponent();

            this.DataContext = new PersonViewModel(new NavigationService());    
        }
        
    }
}
