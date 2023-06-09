﻿

using AutoMapper;
using ecommerce_webapi.Models.Domain;
using ecommerce_webapi.Models.DTO;

namespace ecommerce_webapi.Mappings
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductUserReqDto>().ReverseMap();
            CreateMap<Product, ProductSaveDto>().ReverseMap();
            CreateMap<Quantity, QuantityDto>().ReverseMap();
            CreateMap<QuantityDto, QuantityUserDto>().ReverseMap();

            CreateMap<ImagesUrls, ImagesUrlsSaveDto>().ReverseMap();
            CreateMap<Brand, BrandDto>().ReverseMap();

        }
    }
}
