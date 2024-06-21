using AutoMapper;

namespace CadvancedOpdracht.Models.Dto
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<Location, LocationDto>()
                .ForMember(dest => dest.imageURL, opt => opt.MapFrom(src =>
                    src.Images.FirstOrDefault(i => i.IsCover).Url))
                .ForMember(dest => dest.landlordAvatarURL, opt => opt.MapFrom(src =>
                    src.Landlord.Avatar.Url))
            .ForMember(dest => dest.price, opt => opt.MapFrom(src => src.PricePerDay));

            CreateMap<Image, ImageDto>();
            CreateMap<Landlord, LandlordDto>();
        }
    }
}
