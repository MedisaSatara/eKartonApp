using System;
using System.Collections.Generic;

namespace eKarton.Services.Databases;

public partial class Bolnica
{
    public int BolnicaId { get; set; }

    public string Naziv { get; set; } = null!;

    public string Adresa { get; set; } = null!;

    public string? Telefon { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Administrator> Administrators { get; set; } = new List<Administrator>();

    public virtual ICollection<Odjel> Odjels { get; set; } = new List<Odjel>();
}
