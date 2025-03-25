using HMS.Application.Features.Patients.Commands.Create;
using HMS.Application.Features.Patients.Commands.Update;
using HMS.Domain.Entities;
using HMS.Domain.Enums;
using Mapster;

namespace HMS.Application.Mappings
{
    public class MapsterConfigurations : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreatePatientCommand, Patient>()
            .Map(dest => dest.Gender, src => Enum.Parse<Gender>(src.Gender));

            config.NewConfig<UpdatePatientCommand, Patient>()
            .Map(dest => dest.Gender, src => Enum.Parse<Gender>(src.Gender));
        }
    }
}
