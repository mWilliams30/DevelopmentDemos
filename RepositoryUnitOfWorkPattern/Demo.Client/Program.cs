using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Core.Data;
using Demo.Core.Repositories;

namespace Demo.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new NORTHWNDContext()))
            {
                var employees = unitOfWork.Employees.GetAll();
                var companies = unitOfWork.Orders.GetAll();
                var category = unitOfWork.Categories.Get(1);
                category.CategoryName = "Mark Change";

                var orders = unitOfWork.Orders.Find(o => o.EmployeeID == 5);
                foreach (var order in orders)
                {
                    order.ShipCountry = "Mark Change";
                }

                unitOfWork.SaveChanges();
            }
        }
    }
}
