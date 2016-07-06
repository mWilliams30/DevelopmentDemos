using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Core.Repositories.Interfaces;

namespace Demo.Core.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        IOrderRepository Orders { get; }
        IEmployeeRepository Employees { get; }
        ICategoriesRepository Categories { get; }
        void SaveChanges();
    }
}
