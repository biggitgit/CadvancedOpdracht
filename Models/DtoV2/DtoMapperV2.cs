using AutoMapper;

namespace CadvancedOpdracht.Models.DtoV2
{
    public class DtoMapperV2 : Profile
    {
        public DtoMapperV2()
        {
            CreateMap<Location, LocationDtoV2>()
                .ForMember(dest => dest.imageURL, opt => opt.MapFrom(src =>
                    src.Images.FirstOrDefault(i => i.IsCover).Url))
                .ForMember(dest => dest.landlordAvatarURL, opt => opt.MapFrom(src =>
                    src.Landlord.Avatar.Url))
            .ForMember(dest => dest.price, opt => opt.MapFrom(src => src.PricePerDay));

            CreateMap<Image, ImageDtoV2>();
            CreateMap<Landlord, LandlordDtoV2>();
        }
    }
}
