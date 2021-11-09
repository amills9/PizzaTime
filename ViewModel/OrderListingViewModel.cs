using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

// avoid using this in actual assessment why tho?... Yeah why?
using PizzaTime.Model;

namespace PizzaTime.ViewModel {
    class OrderListingViewModel : ViewModelBase {
        /* Object collection class that is observed at runtime
         * We observe our reservation object so that when 
         * our data bindings change to this object 
         * our list view items also change.
         * Object databinding changes -> observe/update object -> auto update UI
         */
        private readonly ObservableCollection<OrderViewModel> _orders;

        /* Expose collection via Enum -> strong/fast type
         * A form of encapsulation
         * It stops other classes/view models from grabbing/changing our data whenever it pleases
         * If we don't want or don't need to encapsulate obverservable collection type is also fine
         * ie. public ObservableCollection<ReservationViewModel> Reservations => _reservations;
         */
        public IEnumerable<OrderViewModel> Orders => _orders;

        public ICommand LoadOrdersCommand { get; }
        public ICommand MakeOrdersCommand { get; }

        public OrderListingViewModel() {
            _orders = new ObservableCollection<OrderViewModel>();

            List<Ingredient> p1Ingredients = new List<Ingredient>();
            p1Ingredients.Add(new Ingredient("Cheese"));
            p1Ingredients.Add(new Ingredient("Tomato"));
            p1Ingredients.Add(new Ingredient("MysteryMeat"));
            p1Ingredients.Add(new Ingredient("Mushroom"));
            p1Ingredients.Add(new Ingredient("Olive"));

            List<Ingredient> p2Ingredients = new List<Ingredient>();
            p1Ingredients.Add(new Ingredient("Cheese"));

            List<Ingredient> p3Ingredients = new List<Ingredient>();
            p1Ingredients.Add(new Ingredient("Cheese"));
            p1Ingredients.Add(new Ingredient("Olive"));

            _orders.Add(new OrderViewModel(new Model.Order(new Pizza(p1Ingredients), "MC Pizza", DateTime.Now, DateTime.Now)));
            _orders.Add(new OrderViewModel(new Model.Order(new Pizza(p2Ingredients), "Pizza The Hut", DateTime.Now, DateTime.Now)));
            _orders.Add(new OrderViewModel(new Model.Order(new Pizza(p3Ingredients), "Old Greg", DateTime.Now, DateTime.Now)));
        }
    }
}
