using UnitOfWork.Repository;
using System.Collections.Generic;
namespace RepositoryUsingEFinMVC.Repository
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeesByGender(string Gender);
        IEnumerable<Employee> GetEmployeesByDepartment(string Dept);
    }
}