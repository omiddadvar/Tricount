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

    public record GetCategoryByIdQuery : IRequest<GetCategoriesDTO>
    {
        public int CategoryId { get; set; }
    }
}
