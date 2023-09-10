using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace eKarton.Models.Model
{
    public class Doktor
    {
        public int DoktorId { get; set; }

        public string Ime { get; set; } = null!;

        public string Prezime { get; set; } = null!;

        public string? Spol { get; set; }

        public string? DatumRodjenja { get; set; }

        public string? Grad { get; set; }

        public string Jmbg { get; set; } = null!;

        public string? Telefon { get; set; }

        public string? Email { get; set; }

        public int OdjelId { get; set; }

        //   public virtual ICollection<DodjeljeniDoktor> DodjeljeniDoktors { get; set; } = new List<DodjeljeniDoktor>();

        //  public virtual ICollection<OcjenaDoktor> OcjenaDoktors { get; set; } = new List<OcjenaDoktor>();
       // public virtual Odjel Odjel { get; set; } = null!;

      //  public virtual ICollection<Pregled> Pregleds { get; set; } = new List<Pregled>();

      //  public virtual ICollection<Termin> Termins { get; set; } = new List<Termin>();
    }
}
