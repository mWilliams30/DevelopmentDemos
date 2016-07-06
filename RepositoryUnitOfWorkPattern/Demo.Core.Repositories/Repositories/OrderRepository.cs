using System;
using System.Collections.Generic;
using Demo.Core.Data;

namespace Demo.Core.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(NORTHWNDContext context) : base(context)
        {
        }

        public IEnumerable<Order> GetOtherOrder(int param)
        {
            throw new NotImplementedException();
        }

   
    }
}