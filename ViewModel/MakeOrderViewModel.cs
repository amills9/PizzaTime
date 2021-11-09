using System;
using System.Windows.Input;
using PizzaTime.Model;

namespace PizzaTime.ViewModel
{
    public class MakeOrderViewModel : ViewModelBase
    {
        //Property same identifier same as Binding value in PizzaOrderView.xaml
        private string _customer; //Someone set these up properly please

        public string customer
        {
            get
            {
                return _customer;
            }

            set
            {
                _customer = value; //Magic C# automatic parameter "value".
                OnPropertyChanged(nameof(customer));
            }
        }

        private Pizza _pizza; //This might get hairy without an Ingredients -> Pizza conversion layer?
        public Pizza pizza
        {
            get
            {
                return _pizza;
            }

            set
            {
                _pizza = value; //Magic C# automatic parameter "value".
                OnPropertyChanged(nameof(pizza));
            }
        }

        private string _startTime;
        public string startTime
        {
            get
            {
                return _startTime;
            }

            set
            {
                _startTime = value; //Magic C# automatic parameter "value".
                OnPropertyChanged(nameof(startTime));
            }
        }

        private string _endTime;
        public string EndTime
        {
            get
            {
                return _endTime;
            }

            set
            {
                _endTime = value; //Magic C# automatic parameter "value".
                OnPropertyChanged(nameof(EndTime));
            }
        }

        //Commands for our buttons using the ICommand interface
        //Instantiate these later so they do something on click
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeOrderViewModel() {

        }
    }
}