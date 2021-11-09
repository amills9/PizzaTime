using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.Model
{
    class Order
    {
        public Pizza Pizza { get; }
        //Auth Users by string they input -> I stronger typer would be a user ID or Unique ID we can line up with our Database
        public string Customer { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }

        public Order(Pizza pizza, string customer, DateTime startTime, DateTime endTime)
        {
            Pizza = pizza;
            Customer = customer;
            StartTime = startTime;
            EndTime = endTime;
        }

    }
}
