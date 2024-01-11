using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Application.Interfaces.Mapper;
using Tricount.Domain.Entities;

namespace Tricount.Application.Features.DocumentTypes.DTOs
{
    public class GetDocumentTypesDTO : IMapFrom<DocumentType>
    {
        public int DocumentTypeId { get; set; }
        public string DocumentType { get; set; }
    }
}
