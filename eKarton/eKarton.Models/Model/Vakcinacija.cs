using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Models.Model
{
    public class Vakcinacija
    {
        public int VakcinacijaId { get; set; }

        public string NazivVakcine { get; set; } = null!;

      //  public virtual ICollection<PacijentVakcinacija> PacijentVakcinacijas { get; set; } = new List<PacijentVakcinacija>();
    }
}
