﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Models.Request
{
    public class PacijentSearchRequest:BaseSearchObject
    {
        public string? ImePacijenta { get; set; }
        public string? PrezimePacijenta { get; set; }
       // public bool? isDodjeljenDoktor { get; set; }
       // public bool? isOsiguranjeInclude { get; set; }
       // public bool? isPregledInclude { get; set; }
       // public bool? isPreventivneMjereInclude { get; set; }


    }
}
