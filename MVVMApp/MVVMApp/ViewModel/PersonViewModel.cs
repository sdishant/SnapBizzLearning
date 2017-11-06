using MVVMApp.Model;
using MVVMApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.ViewModel
{
    public class PersonViewModel : ViewModelBase
    {
        private string name;

        public string Name
        {
            get { return name; }
            set {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set {
                address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        public RelayCommand RegistrationCommand { get; set; }

        public PersonViewModel()
        {
            RegistrationCommand = new RelayCommand(DoRegistration);
        }

        private void DoRegistration(object obj)
        {
            Person person = new Person();
            person.Name = this.Name;
            person.Age = this.Age;
            person.Address = this.Address;
        }
    }
}
