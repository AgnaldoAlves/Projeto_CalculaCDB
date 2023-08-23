using AutoMapper;
using B3Teste.Application.ViewModels;

namespace B3Teste.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile() {

            CreateMap<Domain.Entities.Cdb, CdbViewModel>();
            CreateMap<Domain.Entities.Imposto, ImpostoViewModel>();
        }
    }
}
