using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Application.Common;
using Tricount.Application.Interfaces.Repositories;
using Tricount.Domain.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Tricount.Application.Features.Categories.Commands.AddCategory
{
    public class AddCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<AddCategoryCommand, int>
    {
        public Task<int> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseValuedCommandResponse();

            var data = await unitOfWork.Repository<TricountCategory>().get

            await unitOfWork.Save();

            response.IsSusses = true;
            response.Id = data.Id;



            return response;
        }
    }
}
