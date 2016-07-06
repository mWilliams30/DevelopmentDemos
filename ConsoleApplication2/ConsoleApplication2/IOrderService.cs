using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public interface IOrderService
    {
        IEnumerable<Order> GetOrders();
        void AddOrder(Order order);
        Order GetOrder(Guid orderId);
    }

    public class OrderService : IOrderService
    {
        public IEnumerable<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void AddOrders(IEnumerable<Order> orders)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }
    }
}
