using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Application.Features.Categories.DTOs;
using Tricount.Domain.Entities;

namespace Tricount.Application.Mapper
{
    public class TricountProfile : Profile
    {
        public TricountProfile()
        {
            CreateMap<GetCategoriesDTO, TricountCategory>();
        }
    }
}
