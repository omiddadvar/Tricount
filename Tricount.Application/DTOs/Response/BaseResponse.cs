using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricount.Application.DTOs.Response
{
    public class BaseResponse<T>
    {
        public List<string> Errors { get; set; }
        public bool IsSuccess { get; set; }
        public T Data {  get; set; }
    }
}
