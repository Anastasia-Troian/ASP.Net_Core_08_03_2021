﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_Core_08_03_2021.Models.DTO.Result
{
    public class CollectionResultDto<T> : ResultDto
    {
        public ICollection<T> ResultCollection { get; set; }
    }
}
