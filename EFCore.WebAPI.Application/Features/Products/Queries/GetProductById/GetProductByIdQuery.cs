using EFCore.WebAPI.Application.Exceptions;
using EFCore.WebAPI.Application.Interfaces.Repositories;
using EFCore.WebAPI.Application.Wrappers;
using EFCore.WebAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<Response<Product>>
    {
        public int Id { get; set; }
        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Response<Product>>
        {
            private readonly IProductRepositoryAsync _productRepository;
            public GetProductByIdQueryHandler(IProductRepositoryAsync productRepository)
            {
                _productRepository = productRepository;
            }
            public async Task<Response<Product>> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
            {
                var product = await _productRepository.GetByIdAsync(query.Id);
                if (product == null) throw new ApiException($"Product Not Found.");
                return new Response<Product>(product);
            }
        }
    }
}
