using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.Model
{
    class Shop
    {
        private readonly OrderTicket _orderTicket;

        public string Name { get; }

        public Shop(string name)
        {
            //Initalise name via contructor
            Name = name;
            _orderTicket = new OrderTicket();
        }


        public IEnumerable<Order> GetOrderForUser(String customer)
        {
            return _orderTicket.GetCustomerTicket(customer);
        }

        public void MakePizza(Order order)
        {
            _orderTicket.AddOrder(order);
        }
    }
}
