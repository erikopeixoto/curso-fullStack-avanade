using Avanade.SubTCSE.Projeto.Data.Repositories.Base;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Data.Repositories.Employee
{
    public class EmplyeeRepository : BaseRepository<Domain.Aggregates.Employee.Entities.Employee, string>
        , IEmployeeRepository
    {

    }
}
