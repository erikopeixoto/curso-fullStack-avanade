using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Repository
{
    public interface IEmployeeRepository
    {
        Task<Entities.Employee> AddEmployee(Entities.Employee employee);
    }
}
