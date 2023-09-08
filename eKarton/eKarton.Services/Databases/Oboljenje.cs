using System;
using System.Collections.Generic;

namespace eKarton.Services.Databases;

public partial class Oboljenje
{
    public int OboljenjeId { get; set; }

    public string? Dijagnoza { get; set; }

    public string? Terapija { get; set; }

    public virtual ICollection<PacijentOboljenja> PacijentOboljenjas { get; set; } = new List<PacijentOboljenja>();
}
