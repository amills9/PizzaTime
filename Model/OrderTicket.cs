using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime.Model
{
    class OrderTicket
    {
        private readonly List<Order> _OrderTicket;

        public OrderTicket()
        {
            _OrderTicket = new List<Order>();
        }

        public IEnumerable<Order> GetCustomerTicket(string customer)
        {
            
            return _OrderTicket.Where(r => r.Customer == customer);
        }

        public void AddOrder(Order order)
        {
            //Check Order before adding them
            //foreach (Order existingOrder in _OrderTicket)
            //{
            //    if (existingRes.Conflicts(reservation))
            //    {
            //        throw new ReservationConflictException(existingRes, reservation);
            //    }
            //}

            _OrderTicket.Add(order);
        }
    }
}
