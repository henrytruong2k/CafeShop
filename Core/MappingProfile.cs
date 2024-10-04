using AutoMapper;
using CafeShop.DTO;
using System.Data;

namespace CafeShop.Core;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Ánh xạ từ DataRow sang AccountDTO
        CreateMap<DataRow, AccountDTO>()
            .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => Convert.ToInt32(src["UserID"])))
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src["UserName"].ToString()))
            .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src["Password"].ToString()))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src["FullName"].ToString()));

        //TODO: add more profiles
        CreateMap<DataRow, FoodDTO>()
           .ForMember(dest => dest.FoodID, opt => opt.MapFrom(src => Convert.ToInt32(src["FoodID"])))
           .ForMember(dest => dest.FoodName, opt => opt.MapFrom(src => src["FoodName"].ToString()))
           .ForMember(dest => dest.IdCategory, opt => opt.MapFrom(src => Convert.ToInt32(src["IdCategory"])))
           .ForMember(dest => dest.Price, opt => opt.MapFrom(src => Convert.ToDouble(src["Price"])));
    }
}