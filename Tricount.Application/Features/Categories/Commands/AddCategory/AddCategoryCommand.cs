﻿using AutoMapper;
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

    public record AddCategoryCommand : IRequest<int>
    {
        public string TricountCategoryName { get; set; }
    }
}
