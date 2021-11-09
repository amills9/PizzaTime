using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PizzaTime.Model;

namespace PizzaTime.ViewModel {
    class OrderViewModel: ViewModelBase {
        private readonly Order _order;

        public string Pizza => _order.Pizza.Ingredients.Select(i => i.ToString()).ToArray().ToString();
        public string Customer => _order.Customer.ToString();
        public string StartTime => _order.StartTime.ToString("dd/MM/yyyy");
        public string EndTime => _order.EndTime.ToString("dd/MM/yyyy");

        public OrderViewModel(Order order) {
            //Grab reservation data model through our viewmodel
            _order = order;
        }
    }
}
