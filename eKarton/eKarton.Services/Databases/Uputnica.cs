using System;
using System.Collections.Generic;

namespace eKarton.Services.Databases;

public partial class Uputnica
{
    public int UputnicaId { get; set; }

    public string Naziv { get; set; } = null!;

    public string Datum { get; set; } = null!;

    public string Razlog { get; set; } = null!;

    public virtual ICollection<Pregled> Pregleds { get; set; } = new List<Pregled>();
}
