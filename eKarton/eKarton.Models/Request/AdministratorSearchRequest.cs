using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Models.Request
{
    public class AdministratorSearchRequest:BaseSearchObject
    {
        public string? ImeAdministratora { get; set; }
        public string? PrezimeAdministratora { get; set; }
        public bool? isAdministratorInclude { get; set; }

    }
}
