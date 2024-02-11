using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Application.Common;
using Tricount.Application.Interfaces.Repositories;

namespace Tricount.Application.Features.Categories.Commands.AddCategory
{

    public record AddCategoryCommand : IRequest<>
    {
        public string TricountCategoryName { get; set; }
    }
    public class AddCategoryCommandHandler : BaseCommandQueryClass<AddCategoryCommand, int>
    {
        public AddCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : 
            base(unitOfWork, mapper) {}

        public override Task<int> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
