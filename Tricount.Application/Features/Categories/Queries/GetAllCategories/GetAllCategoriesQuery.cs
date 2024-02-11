using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Application.Common;
using Tricount.Application.Features.Categories.DTOs;
using Tricount.Application.Interfaces.Repositories;
using Tricount.Domain.Entities;

namespace Tricount.Application.Features.Categories.Queries.GetAllCategories
{
    public record GetAllCategoriesQuery : IRequest<IEnumerable<GetCategoriesDTO>>;
    public class GetAllCategoriesQueryHandler : BaseCommandQueryClass<GetAllCategoriesQuery, IEnumerable<GetCategoriesDTO>>
    {
        public GetAllCategoriesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : 
            base(unitOfWork, mapper) {}

        public override async Task<IEnumerable<GetCategoriesDTO>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.Repository<TricountCategory>().GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<GetCategoriesDTO>>(data);
            //return await _unitOfWork.Repository<TricountCategory>().Entities
            //    .ProjectTo<GetAllCategoriesDTO>(_mapper.ConfigurationProvider)
            //    .ToListAsync(cancellationToken);
        }
    }
}
