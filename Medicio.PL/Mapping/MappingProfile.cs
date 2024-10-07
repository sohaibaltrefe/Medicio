using AutoMapper;
using Medicio.DAL.Models;
using Medicio.PL.Areas.Dashboard.ViewModels;

namespace Medicio.PL.Mapping
{
    public class MappingProfile :Profile
    {
            public MappingProfile() {
            CreateMap<ServiceFormVM, Service>();
            CreateMap<Service, ServicesVM>();
            CreateMap<Service, serviceDetailsVM>();

        }

    }
}
