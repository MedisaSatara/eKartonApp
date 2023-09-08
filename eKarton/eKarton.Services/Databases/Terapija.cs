using System;
using System.Collections.Generic;

namespace eKarton.Services.Databases;

public partial class Terapija
{
    public int TerapijaId { get; set; }

    public string NazivLijeka { get; set; } = null!;

    public string? Uputa { get; set; }

    public string Od { get; set; } = null!;

    public string Do { get; set; } = null!;

    public string? Podsjetnik { get; set; }

    public virtual ICollection<Pregled> Pregleds { get; set; } = new List<Pregled>();
}
