using System;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Entities
{
    public record Employee : BaseEntity<string>
    {

        public Employee(string firstName, 
            string surName, 
            DateTime birthiday, 
            bool active, 
            decimal salary, 
            EmployeeRole.Entities.EmployeeRole employeeRole)
        {
            SurName = surName;
            Birthiday = birthiday;
            Active = active;
            Salary = salary;
            EmployeeRole = employeeRole;
        }

        public string FirstName { get; init; }
        public string SurName { get; init; }
        public DateTime Birthiday { get; init; }
        public bool Active { get; init; }
        public decimal Salary { get; init; }
        public EmployeeRole.Entities.EmployeeRole EmployeeRole { get; init; }

    }
}
