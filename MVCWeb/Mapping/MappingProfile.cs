using AutoMapper;
using MVC.Domain;
using MVCWeb.Models;
using MVCWeb.Models.Reports;

namespace MVCWeb.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Products, ProductViewModel>();
            CreateMap<Report, ReportsViewModel>();
        }
    }
}