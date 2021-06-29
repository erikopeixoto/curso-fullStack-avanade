using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Validators;
using FluentValidation;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Validators
{
    class EmplyeeValidatior : AbstractValidator<Entities.Employee>
    {
        public EmplyeeValidatior()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.FirstName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty.");

                RuleFor(e => e.Salary)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty.");

                RuleFor(e => e.SurName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty.");

                RuleFor(e => e.EmployeeRole)
                .SetValidator(new EmplyeeRoleValidatior());
            });
        }
    }
}
