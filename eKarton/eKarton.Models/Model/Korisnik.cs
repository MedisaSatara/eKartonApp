using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Models.Model
{
    public class Korisnik
    {
        public int KorisnikId { get; set; }

        public string Ime { get; set; } = null!;

        public string Prezime { get; set; } = null!;

        public string KorisnickoIme { get; set; } = null!;

        public string? LozinkaSalt { get; set; }

        public string? LozinkaHash { get; set; }

        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; } = new List<KorisnikUloga>();

       // public virtual ICollection<Pacijent> Pacijents { get; set; } = new List<Pacijent>();
    }
}
