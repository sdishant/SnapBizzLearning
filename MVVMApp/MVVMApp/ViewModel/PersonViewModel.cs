using MVVMApp.Interfaces;
using MVVMApp.Model;
using MVVMApp.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace MVVMApp.ViewModel
{
    public class PersonViewModel : ViewModelBase
    {
        public INavigationService NavigationService { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        public RelayCommand RegistrationCommand { get; set; }

        public PersonViewModel(INavigationService navigationService)
        {
            RegistrationCommand = new RelayCommand(DoRegistration);
            NavigationService = navigationService;
        }

        private async void DoRegistration(object obj)
        {
            Person person = new Person();
            person.Name = this.Name;
            person.Age = this.Age;
            person.Address = this.Address;
            await DoSomeResourceInsiveTaskAsync(UpdateUIImage);
            //NavigationService.NavigateTo(typeof(Welcome), person);
        }

        private async Task<int> DoSomeResourceInsiveTaskAsync(Action<int> UpdateUIImage)
        {
            int sum = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    sum += 10 * i + 1;  
                    if (i % 4 == 0)
                    {
                        CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
                         () =>
                         {
                             UpdateUIImage(sum);
                         });
                    }
                    Debug.WriteLine(sum);
                }
            });
            return sum;
        }

        private void UpdateUIImage(int Sum)
        {
            Age = Sum;
        }
        
    }
}
