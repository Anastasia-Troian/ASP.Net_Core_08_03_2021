using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_Core_08_03_2021.Models.DTO.Result
{
    public class SingleResultDto<T> : ResultDto
    {
        public T Result { get; set; }
    }
}
