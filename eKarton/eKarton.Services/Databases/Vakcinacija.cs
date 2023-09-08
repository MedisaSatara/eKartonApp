using System;
using System.Collections.Generic;

namespace eKarton.Services.Databases;

public partial class Vakcinacija
{
    public int VakcinacijaId { get; set; }

    public string NazivVakcine { get; set; } = null!;

    public virtual ICollection<PacijentVakcinacija> PacijentVakcinacijas { get; set; } = new List<PacijentVakcinacija>();
}
