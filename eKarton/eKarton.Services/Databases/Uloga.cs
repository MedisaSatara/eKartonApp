﻿using System;
using System.Collections.Generic;

namespace eKarton.Services.Databases;

public partial class Uloga
{
    public int UlogaId { get; set; }

    public string? Naziv { get; set; }

    public string? OpisUloge { get; set; }

    public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; } = new List<KorisnikUloga>();
}
