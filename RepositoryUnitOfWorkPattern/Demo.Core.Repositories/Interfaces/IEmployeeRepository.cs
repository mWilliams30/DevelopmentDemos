using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Core.Data;

namespace Demo.Core.Repositories.Interfaces
{
    public interface IEmployeeRepository: IRepository<Employee>
    {
    }
}
