using System;
using System.Collections.Generic;

namespace eKarton.Services.Databases;

public partial class Odjel
{
    public int OdjelId { get; set; }

    public string Naziv { get; set; } = null!;

    public string? Telefon { get; set; }

    public int BolnicaId { get; set; }

    public virtual Bolnica Bolnica { get; set; } = null!;

    public virtual ICollection<Doktor> Doktors { get; set; } = new List<Doktor>();
}
