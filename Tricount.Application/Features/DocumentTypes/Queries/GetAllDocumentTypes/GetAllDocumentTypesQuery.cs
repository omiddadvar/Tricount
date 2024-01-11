using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Application.Features.Categories.DTOs;
using Tricount.Application.Features.DocumentTypes.DTOs;
using Tricount.Application.Interfaces.Repositories;
using Tricount.Domain.Entities;

namespace Tricount.Application.Features.DocumentTypes.Queries.GetAllDocumentTypes
{
    public record GetAllDocumentTypesQuery : IRequest<IEnumerable<GetDocumentTypesDTO>>;

    public class GetAllDocumentTypesQueryHandler : IRequestHandler<GetAllDocumentTypesQuery, IEnumerable<GetDocumentTypesDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllDocumentTypesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetDocumentTypesDTO>> Handle(GetAllDocumentTypesQuery request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.Repository<DocumentType>().GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<GetDocumentTypesDTO>>(data);
        }
    }
}
