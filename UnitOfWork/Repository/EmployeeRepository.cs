using System.Linq;
using System.Collections.Generic;
using RepositoryUsingEFinMVC.GenericRepository;
using UnitOfWork.Repository;
namespace RepositoryUsingEFinMVC.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IUnitOfWork<EmployeeDBContext> unitOfWork)
            : base(unitOfWork)
        {
        }

        public EmployeeRepository(EmployeeDBContext context)
            : base(context)
        {
        }

        public IEnumerable<Employee> GetEmployeesByGender(string Gender)
        {
            return Context.Employees.Where(emp => emp.Gender == Gender).ToList();
        }

        public IEnumerable<Employee> GetEmployeesByDepartment(string Dept)
        {
            return Context.Employees.Where(emp => emp.Dept == Dept).ToList();
        }
    }
}