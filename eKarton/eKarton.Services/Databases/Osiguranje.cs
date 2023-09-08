using System;
using System.Collections.Generic;

namespace eKarton.Services.Databases;

public partial class Osiguranje
{
    public int OsiguranjeId { get; set; }

    public string Osiguranik { get; set; } = null!;

    public virtual ICollection<PacijentOsiguranje> PacijentOsiguranjes { get; set; } = new List<PacijentOsiguranje>();
}
