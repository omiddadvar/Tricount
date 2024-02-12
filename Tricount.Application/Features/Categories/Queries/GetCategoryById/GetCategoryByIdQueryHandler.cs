using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Application.Common;
using Tricount.Application.Features.Categories.DTOs;
using Tricount.Application.Interfaces.Repositories;
using Tricount.Domain.Entities;

namespace Tricount.Application.Features.Categories.Queries.GetCategoryById
{
    public class GetCategoryByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<GetCategoryByIdQuery, GetCategoriesDTO>
    {
        public async Task<GetCategoriesDTO> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.Repository<TricountCategory>()
                .GetByIdAsync(request.CategoryId, cancellationToken);
            return mapper.Map<GetCategoriesDTO>(data);
        }
    }
}
