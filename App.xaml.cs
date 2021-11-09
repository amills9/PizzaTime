using PizzaTime.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PizzaTime.ViewModel;

namespace PizzaTime
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            //Shop shop = new Shop("Studentz Foodz");

            ////try
            ////{
            ////Pizza Test
            //shop.MakePizza(new Order(
            //    new Pizza(
            //    new Ingrediants("Thin", "Cheese", "Cherry Tamatoes", "Basil", "Pepperoni")),
            //    "Shaun",
            //    new DateTime(2000, 1, 1),  //Start time
            //    new DateTime(2000, 1, 2)));  //End time

            MainWindow = new MainWindow() {
                DataContext = new MainViewModel()
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
