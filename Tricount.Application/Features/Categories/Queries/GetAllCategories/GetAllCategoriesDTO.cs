using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Application.Interfaces.Mapper;
using Tricount.Domain.Entities;

namespace Tricount.Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoriesDTO : IMapFrom<TricountCategory>
    {
        public int TricountCategoryId { get; set; }
        public string TricountCategoryName { get; set; }
    }
}
