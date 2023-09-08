using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Models.Model
{
    public class Pacijent
    {
        public int PacijentId { get; set; }

        public string Ime { get; set; } = null!;

        public string Prezime { get; set; } = null!;

        public string Spol { get; set; } = null!;

        public string? DatumRodjenja { get; set; }

        public string Jmbg { get; set; } = null!;

        public string? MjestoRodjenja { get; set; }

        public string? Prebivaliste { get; set; }

        public string Telefon { get; set; } = null!;

        public string? KrvnaGrupa { get; set; }

        public string? RhFaktor { get; set; }

        public string? HronicneBolesti { get; set; }

        public string? Alergija { get; set; }

        public bool? Koagulopatija { get; set; }

        public string BrojKartona { get; set; } = null!;

        public string KorisnickoIme { get; set; } = null!;

        public string? LozinkaSalt { get; set; }

        public string? LozinkaHash { get; set; }

        public int KorisnikId { get; set; }

        public virtual ICollection<DodjeljeniDoktor> DodjeljeniDoktors { get; set; } = new List<DodjeljeniDoktor>();

        public virtual Korisnik Korisnik { get; set; } = null!;

    //    public virtual ICollection<Nalaz> Nalazs { get; set; } = new List<Nalaz>();

      //  public virtual ICollection<PacijentOboljenja> PacijentOboljenjas { get; set; } = new List<PacijentOboljenja>();

        public virtual ICollection<PacijentOsiguranje> PacijentOsiguranjes { get; set; } = new List<PacijentOsiguranje>();

     //   public virtual ICollection<PacijentVakcinacija> PacijentVakcinacijas { get; set; } = new List<PacijentVakcinacija>();

        public virtual ICollection<Pregled> Pregleds { get; set; } = new List<Pregled>();

        public virtual ICollection<PreventivneMjere> PreventivneMjeres { get; set; } = new List<PreventivneMjere>();

      //  public virtual ICollection<SistematskiPregled> SistematskiPregleds { get; set; } = new List<SistematskiPregled>();

       // public virtual ICollection<Termin> Termins { get; set; } = new List<Termin>();
    }
}
