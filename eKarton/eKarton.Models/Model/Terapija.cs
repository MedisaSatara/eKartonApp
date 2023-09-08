﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Models.Model
{
    public class Terapija
    {
        public int TerapijaId { get; set; }

        public string NazivLijeka { get; set; } = null!;

        public string? Uputa { get; set; }

        public string Od { get; set; } = null!;

        public string Do { get; set; } = null!;

        public string? Podsjetnik { get; set; }

        public virtual ICollection<Pregled> Pregleds { get; set; } = new List<Pregled>();
    }
}
