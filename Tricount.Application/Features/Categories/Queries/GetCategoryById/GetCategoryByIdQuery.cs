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

namespace Tricount.Application.Features.Categories.Queries.GetCategoryById
{

    public record GetCategoryByIdQuery : IRequest<GetCategoriesDTO>
    {
        public int CategoryId { get; set; }
    }
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoriesDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetCategoryByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetCategoriesDTO> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.Repository<TricountCategory>()
                .GetByIdAsync(request.CategoryId, cancellationToken);
            return _mapper.Map<GetCategoriesDTO>(data);
        }
    }
}
