
using API.Dtos;
using AutoMapper;
using core.Entities;

namespace API.Helpers
{
    public class MapingProfiles : Profile
    {
        public MapingProfiles()
        {
            CreateMap<Product,ProductToReturnDto>()
               .ForMember(d=> d.ProductBrand,o=> o.MapFrom(s=>s.ProductBrand.Name))
               .ForMember(d=> d.ProductType,o=> o.MapFrom(s=>s.ProductType.Name))
               .ForMember(d=> d.PictureUrl,o=> o.MapFrom<ProductUrlResolver>());
        }
    }
}    