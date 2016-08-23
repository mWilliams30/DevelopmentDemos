using System;
using Demo.Core.Data;
using Demo.Core.Repositories.Interfaces;

namespace Demo.Core.Repositories
{
    public class NorthwindWork : IUnitOfWork
    {
        private readonly NORTHWNDContext _context;
        public IOrderRepository Orders { get; }
        public IEmployeeRepository Employees { get; }
        public ICategoriesRepository Categories { get; }

        public NorthwindWork(NORTHWNDContext context)
        {
            _context = context;
            Orders = new OrderRepository(_context);
            Employees = new EmployeeRepository(_context );
            Categories = new CategoriesRepository(_context);
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}