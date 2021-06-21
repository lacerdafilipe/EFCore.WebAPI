using EFCore.WebAPI.Application.Features.Products.Commands.CreateProduct;
using EFCore.WebAPI.Application.Features.Products.Queries.GetAllProducts;
using AutoMapper;
using EFCore.WebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.WebAPI.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
