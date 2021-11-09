using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.ViewModel {
    class MainViewModel : ViewModelBase {
        public ViewModelBase CurrentViewModel { get; }
        public MainViewModel()
        {
            //CurrentViewModel = new OrderListingViewModel();

            CurrentViewModel = new MakeOrderViewModel(); //If you're switching this, remember to switch in MainWindow.xaml!
        }
    }
}
