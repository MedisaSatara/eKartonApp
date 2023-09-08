using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Models.Request
{
    public class KorisnikSearchRequest
    {
        public string? ImeKorisnika { get; set; }
        public string? PrezimeKorisnika { get; set; }
        public string? KorisnickoIme { get; set; }
        public string? UlogaKorisnika { get; set; }
    }
}
