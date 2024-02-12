using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Application.Features.Categories.DTOs;
using Tricount.Application.Interfaces.Repositories;
using Tricount.Domain.Entities;

namespace Tricount.Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoriesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<GetAllCategoriesQuery, IEnumerable<GetCategoriesDTO>>
    {
        public async Task<IEnumerable<GetCategoriesDTO>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.Repository<TricountCategory>().GetAllAsync(cancellationToken);
            return mapper.Map<IEnumerable<GetCategoriesDTO>>(data);
            //return await _unitOfWork.Repository<TricountCategory>().Entities
            //    .ProjectTo<GetAllCategoriesDTO>(_mapper.ConfigurationProvider)
            //    .ToListAsync(cancellationToken);
        }
    }
}
