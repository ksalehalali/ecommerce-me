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
           // CreateMap<ProductUserReqDto, Product>().ReverseMap();
      
        }
    }
}