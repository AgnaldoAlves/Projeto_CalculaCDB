﻿using AutoMapper;
using B3Teste.Application.ViewModels;

namespace B3Teste.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile() {

            CreateMap<CdbViewModel, Domain.Entities.Cdb>();
            CreateMap<ImpostoViewModel, Domain.Entities.Imposto>();
        }
    }
}
