using Demo.Core.Data;

namespace Demo.Core.Repositories.Interfaces
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(NORTHWNDContext context) : base(context)
        {
        }
    }
}