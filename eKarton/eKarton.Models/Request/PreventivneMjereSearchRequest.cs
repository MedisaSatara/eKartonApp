﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Models.Request
{
    public class PreventivneMjereSearchRequest:BaseSearchObject
    {
        public bool? isPacijentIncluded { get; set; }
    }
}
