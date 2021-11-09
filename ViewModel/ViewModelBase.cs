using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PizzaTime.ViewModel {
    public class ViewModelBase : INotifyPropertyChanged {
        //We raise this event in INotifyPropertyChanged to tell our UI what databindings to update
        //What properties are we changing -> so update these
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) {
            // Grabbing a property value and updating our UI
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
