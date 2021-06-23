using FluentValidation;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Validators
{
    class EmplyeeRoleValidatior : AbstractValidator<Entities.EmployeeRole>
    {
        public EmplyeeRoleValidatior()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.RoleName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty.");
            });
        }
    }
}
