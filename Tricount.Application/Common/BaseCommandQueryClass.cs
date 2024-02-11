using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Application.Interfaces.Repositories;

namespace Tricount.Application.Common
{
    public abstract class BaseCommandQueryClass<TRequest, TResponse> : IRequestHandler<TRequest ,TResponse> where TRequest : IRequest<TResponse>
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;
        public BaseCommandQueryClass(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
