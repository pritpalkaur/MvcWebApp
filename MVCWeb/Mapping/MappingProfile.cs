using AutoMapper;
using MVC.Domain;
using MVCWeb.Models;

namespace MVCWeb.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Products, ProductViewModel>();
        }
    }
}