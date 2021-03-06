using AutoMapper;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfig.Profiles.Employee
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Dtos.Employee.EmployeeDto, Domain.Aggregates.Employee.Entities.Employee>()
                .ConstructUsing((ctor, res) =>
                {
                    return new Domain.Aggregates.Employee.Entities.Employee(
                        firstName: ctor.PrimeiroNome,
                        surName: ctor.SobreNome,
                        birthiday: ctor.Aniversario,
                        active: ctor.Ativo,
                        ctor.Salario,
                        employeeRole: res.Mapper.Map<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>(ctor.Cargo)
                        );
                })
                .ForAllOtherMembers(i => i.Ignore());

            CreateMap<Domain.Aggregates.Employee.Entities.Employee, Dtos.Employee.EmployeeDto>()
                .ForMember(dest => dest.Identificador, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PrimeiroNome, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.SobreNome, opt => opt.MapFrom(src => src.SurName))
                .ForMember(dest => dest.Salario, opt => opt.MapFrom(src => src.Salary))
                .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.EmployeeRole))
                .ForMember(dest => dest.Ativo, opt => opt.MapFrom(src => src.Active))
                .ForMember(dest => dest.Aniversario, opt => opt.MapFrom(src => src.Birthiday))
                .ForAllOtherMembers(i => i.Ignore());

        }
    }
}
