using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace eKarton.Services.Databases;

public partial class EKartonContext : DbContext
{
    public EKartonContext()
    {
    }

    public EKartonContext(DbContextOptions<EKartonContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrator> Administrators { get; set; }

    public virtual DbSet<Bolnica> Bolnicas { get; set; }

    public virtual DbSet<DodjeljeniDoktor> DodjeljeniDoktors { get; set; }

    public virtual DbSet<Doktor> Doktors { get; set; }

    public virtual DbSet<Korisnik> Korisniks { get; set; }

    public virtual DbSet<KorisnikUloga> KorisnikUlogas { get; set; }

    public virtual DbSet<Nalaz> Nalazs { get; set; }

    public virtual DbSet<Oboljenje> Oboljenjes { get; set; }

    public virtual DbSet<OcjenaDoktor> OcjenaDoktors { get; set; }

    public virtual DbSet<Odjel> Odjels { get; set; }

    public virtual DbSet<Osiguranje> Osiguranjes { get; set; }

    public virtual DbSet<Pacijent> Pacijents { get; set; }

    public virtual DbSet<PacijentOboljenja> PacijentOboljenjas { get; set; }

    public virtual DbSet<PacijentOsiguranje> PacijentOsiguranjes { get; set; }

    public virtual DbSet<PacijentVakcinacija> PacijentVakcinacijas { get; set; }

    public virtual DbSet<Pregled> Pregleds { get; set; }

    public virtual DbSet<PreventivneMjere> PreventivneMjeres { get; set; }

    public virtual DbSet<SistematskiPregled> SistematskiPregleds { get; set; }

    public virtual DbSet<Terapija> Terapijas { get; set; }

    public virtual DbSet<Termin> Termins { get; set; }

    public virtual DbSet<Uloga> Ulogas { get; set; }

    public virtual DbSet<Uputnica> Uputnicas { get; set; }

    public virtual DbSet<Vakcinacija> Vakcinacijas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source = Desktop-6e66b9l; Initial Catalog = eKarton; User=Sa; Password=st123; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrator>(entity =>
        {
            entity.HasKey(e => e.AdministratorId).HasName("PK__Administ__ACDEFED325B5A97A");

            entity.ToTable("Administrator");

            entity.Property(e => e.DatumRodjenja).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Ime).HasMaxLength(30);
            entity.Property(e => e.Prebivaliste).HasMaxLength(50);
            entity.Property(e => e.Prezime).HasMaxLength(30);
            entity.Property(e => e.Telefon).HasMaxLength(20);

            entity.HasOne(d => d.Bolnica).WithMany(p => p.Administrators)
                .HasForeignKey(d => d.BolnicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bolnica_Administrator");
        });

        modelBuilder.Entity<Bolnica>(entity =>
        {
            entity.HasKey(e => e.BolnicaId).HasName("PK__Bolnica__CA2F6D02B2781985");

            entity.ToTable("Bolnica");

            entity.Property(e => e.Adresa).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Naziv).HasMaxLength(100);
            entity.Property(e => e.Telefon).HasMaxLength(20);
        });

        modelBuilder.Entity<DodjeljeniDoktor>(entity =>
        {
            entity.HasKey(e => e.DodjeljeniDoktorId).HasName("PK__Dodjelje__1CE005076B43C588");

            entity.ToTable("DodjeljeniDoktor");

            entity.Property(e => e.DatumOd).HasMaxLength(20);

            entity.HasOne(d => d.Doktor).WithMany(p => p.DodjeljeniDoktors)
                .HasForeignKey(d => d.DoktorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Doktor_DodjeljeniDoktor");

            entity.HasOne(d => d.Pacijent).WithMany(p => p.DodjeljeniDoktors)
                .HasForeignKey(d => d.PacijentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pacijent_DodjeljeniDoktor");
        });

        modelBuilder.Entity<Doktor>(entity =>
        {
            entity.HasKey(e => e.DoktorId).HasName("PK__Doktor__77AF86A18FB8A643");

            entity.ToTable("Doktor");

            entity.Property(e => e.DatumRodjenja).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Grad).HasMaxLength(30);
            entity.Property(e => e.Ime).HasMaxLength(30);
            entity.Property(e => e.Jmbg)
                .HasMaxLength(13)
                .HasColumnName("JMBG");
            entity.Property(e => e.Prezime).HasMaxLength(30);
            entity.Property(e => e.Spol).HasMaxLength(1);
            entity.Property(e => e.Telefon).HasMaxLength(20);

            entity.HasOne(d => d.Odjel).WithMany(p => p.Doktors)
                .HasForeignKey(d => d.OdjelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Odjel_Doktor");
        });

        modelBuilder.Entity<Korisnik>(entity =>
        {
            entity.HasKey(e => e.KorisnikId).HasName("PK__Korisnik__80B06D41C23855A9");

            entity.ToTable("Korisnik");

            entity.Property(e => e.Ime).HasMaxLength(30);
            entity.Property(e => e.KorisnickoIme).HasMaxLength(20);
            entity.Property(e => e.LozinkaHash).HasMaxLength(250);
            entity.Property(e => e.LozinkaSalt).HasMaxLength(250);
            entity.Property(e => e.Prezime).HasMaxLength(30);
        });

        modelBuilder.Entity<KorisnikUloga>(entity =>
        {
            entity.HasKey(e => e.KorisnikUlogaId).HasName("PK__Korisnik__1608726EED811825");

            entity.ToTable("KorisnikUloga");

            entity.Property(e => e.DatumIzmjene).HasColumnType("date");

            entity.HasOne(d => d.Korisnik).WithMany(p => p.KorisnikUlogas)
                .HasForeignKey(d => d.KorisnikId)
                .HasConstraintName("FK_Korisnik_KorisnikUloga");

            entity.HasOne(d => d.Uloga).WithMany(p => p.KorisnikUlogas)
                .HasForeignKey(d => d.UlogaId)
                .HasConstraintName("FK_Uloga_KorisnikUloga");
        });

        modelBuilder.Entity<Nalaz>(entity =>
        {
            entity.HasKey(e => e.NalazId).HasName("PK__Nalaz__623D2A8BFF103450");

            entity.ToTable("Nalaz");

            entity.Property(e => e.Datum).HasMaxLength(20);
            entity.Property(e => e.LicnaAnamneza).HasMaxLength(250);
            entity.Property(e => e.RadnaAnamneza).HasMaxLength(250);

            entity.HasOne(d => d.Pacijent).WithMany(p => p.Nalazs)
                .HasForeignKey(d => d.PacijentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nalaz_Pacijent");
        });

        modelBuilder.Entity<Oboljenje>(entity =>
        {
            entity.HasKey(e => e.OboljenjeId).HasName("PK__Oboljenj__87F5825088375D37");

            entity.ToTable("Oboljenje");

            entity.Property(e => e.Dijagnoza).HasMaxLength(250);
            entity.Property(e => e.Terapija).HasMaxLength(250);
        });

        modelBuilder.Entity<OcjenaDoktor>(entity =>
        {
            entity.HasKey(e => e.OcjenaId).HasName("PK__OcjenaDo__E6FC7AA922E84C77");

            entity.ToTable("OcjenaDoktor");

            entity.Property(e => e.Razlog).HasMaxLength(250);

            entity.HasOne(d => d.Doktor).WithMany(p => p.OcjenaDoktors)
                .HasForeignKey(d => d.DoktorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Doktor_OcjenaDoktor");
        });

        modelBuilder.Entity<Odjel>(entity =>
        {
            entity.HasKey(e => e.OdjelId).HasName("PK__Odjel__FAE1DA31B22A8E70");

            entity.ToTable("Odjel");

            entity.Property(e => e.Naziv).HasMaxLength(200);
            entity.Property(e => e.Telefon).HasMaxLength(20);

            entity.HasOne(d => d.Bolnica).WithMany(p => p.Odjels)
                .HasForeignKey(d => d.BolnicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bolnica_Odjel");
        });

        modelBuilder.Entity<Osiguranje>(entity =>
        {
            entity.HasKey(e => e.OsiguranjeId).HasName("PK__Osiguran__4FB0CCF94E4E8355");

            entity.ToTable("Osiguranje");

            entity.Property(e => e.Osiguranik).HasMaxLength(250);
        });

        modelBuilder.Entity<Pacijent>(entity =>
        {
            entity.HasKey(e => e.PacijentId).HasName("PK__Pacijent__7471C19D400E481C");

            entity.ToTable("Pacijent");

            entity.Property(e => e.Alergija).HasMaxLength(250);
            entity.Property(e => e.BrojKartona).HasMaxLength(10);
            entity.Property(e => e.DatumRodjenja).HasMaxLength(10);
            entity.Property(e => e.HronicneBolesti).HasMaxLength(250);
            entity.Property(e => e.Ime).HasMaxLength(30);
            entity.Property(e => e.Jmbg)
                .HasMaxLength(13)
                .HasColumnName("JMBG");
            entity.Property(e => e.KorisnickoIme).HasMaxLength(20);
            entity.Property(e => e.KrvnaGrupa).HasMaxLength(10);
            entity.Property(e => e.LozinkaHash).HasMaxLength(50);
            entity.Property(e => e.LozinkaSalt).HasMaxLength(50);
            entity.Property(e => e.MjestoRodjenja).HasMaxLength(50);
            entity.Property(e => e.Prebivaliste).HasMaxLength(50);
            entity.Property(e => e.Prezime).HasMaxLength(30);
            entity.Property(e => e.RhFaktor).HasMaxLength(20);
            entity.Property(e => e.Spol).HasMaxLength(1);
            entity.Property(e => e.Telefon).HasMaxLength(20);

            entity.HasOne(d => d.Korisnik).WithMany(p => p.Pacijents)
                .HasForeignKey(d => d.KorisnikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Korisnik_Pacijent");
        });

        modelBuilder.Entity<PacijentOboljenja>(entity =>
        {
            entity.HasKey(e => e.PacijentOboljenjaId).HasName("PK__Pacijent__826DDBC1ECCEA18F");

            entity.ToTable("PacijentOboljenja");

            entity.Property(e => e.NesposobanZaRad).HasMaxLength(250);
            entity.Property(e => e.NesposobanZaRadDo).HasMaxLength(20);
            entity.Property(e => e.NesposobanZaRadOd).HasMaxLength(20);

            entity.HasOne(d => d.Oboljenje).WithMany(p => p.PacijentOboljenjas)
                .HasForeignKey(d => d.OboljenjeId)
                .HasConstraintName("FK_Oboljenje_PacijentOboljenja");

            entity.HasOne(d => d.Pacijent).WithMany(p => p.PacijentOboljenjas)
                .HasForeignKey(d => d.PacijentId)
                .HasConstraintName("FK_Pacijent_PacijentOboljenja");
        });

        modelBuilder.Entity<PacijentOsiguranje>(entity =>
        {
            entity.HasKey(e => e.PacijentOsiguranjeId).HasName("PK__Pacijent__0D00B6812884E8F7");

            entity.ToTable("PacijentOsiguranje");

            entity.Property(e => e.DatumOsiguranja).HasMaxLength(20);

            entity.HasOne(d => d.Osiguranje).WithMany(p => p.PacijentOsiguranjes)
                .HasForeignKey(d => d.OsiguranjeId)
                .HasConstraintName("FK_Osiguranje_PacijentOsiguranje");

            entity.HasOne(d => d.Pacijent).WithMany(p => p.PacijentOsiguranjes)
                .HasForeignKey(d => d.PacijentId)
                .HasConstraintName("FK_Pacijent_PacijentOsiguranje");
        });

        modelBuilder.Entity<PacijentVakcinacija>(entity =>
        {
            entity.HasKey(e => e.PacijentVakcinacijaId).HasName("PK__Pacijent__1E4E468C5F35C5A4");

            entity.ToTable("PacijentVakcinacija");

            entity.Property(e => e.Datum).HasMaxLength(20);
            entity.Property(e => e.Lokacija).HasMaxLength(50);

            entity.HasOne(d => d.Pacijent).WithMany(p => p.PacijentVakcinacijas)
                .HasForeignKey(d => d.PacijentId)
                .HasConstraintName("FK_Pacijent_PacijentVakcinacija");

            entity.HasOne(d => d.Vakcinacija).WithMany(p => p.PacijentVakcinacijas)
                .HasForeignKey(d => d.VakcinacijaId)
                .HasConstraintName("FK_Vakcinacija_PacijentVakcinacija");
        });

        modelBuilder.Entity<Pregled>(entity =>
        {
            entity.HasKey(e => e.PregledId).HasName("PK__Pregled__4A8CB6D49D27FC58");

            entity.ToTable("Pregled");

            entity.Property(e => e.Datum).HasMaxLength(20);
            entity.Property(e => e.Dijagnoza).HasMaxLength(250);
            entity.Property(e => e.RazlogPosjete).HasMaxLength(250);

            entity.HasOne(d => d.Doktor).WithMany(p => p.Pregleds)
                .HasForeignKey(d => d.DoktorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Doktor_Pregled");

            entity.HasOne(d => d.Pacijent).WithMany(p => p.Pregleds)
                .HasForeignKey(d => d.PacijentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pacijent_Pregled");

            entity.HasOne(d => d.Terapija).WithMany(p => p.Pregleds)
                .HasForeignKey(d => d.TerapijaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Terapija_Pregled");

            entity.HasOne(d => d.Uputnica).WithMany(p => p.Pregleds)
                .HasForeignKey(d => d.UputnicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Uputnica_Pregled");
        });

        modelBuilder.Entity<PreventivneMjere>(entity =>
        {
            entity.HasKey(e => e.PreventivneMjereId).HasName("PK__Preventi__83A48E9352D3DF55");

            entity.ToTable("PreventivneMjere");

            entity.Property(e => e.Stanje).HasMaxLength(100);

            entity.HasOne(d => d.Pacijent).WithMany(p => p.PreventivneMjeres)
                .HasForeignKey(d => d.PacijentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pacijent_Mjere");
        });

        modelBuilder.Entity<SistematskiPregled>(entity =>
        {
            entity.HasKey(e => e.SistematskiPregledId).HasName("PK__Sistemat__F3762777F78B82FB");

            entity.ToTable("SistematskiPregled");

            entity.Property(e => e.Abdomen).HasMaxLength(50);
            entity.Property(e => e.Bmi)
                .HasMaxLength(20)
                .HasColumnName("BMI");
            entity.Property(e => e.Cula).HasMaxLength(50);
            entity.Property(e => e.Datum).HasMaxLength(20);
            entity.Property(e => e.Ekstremiteti).HasMaxLength(50);
            entity.Property(e => e.GrudniKos).HasMaxLength(50);
            entity.Property(e => e.KicmeniStub).HasMaxLength(50);
            entity.Property(e => e.KrvniPritisak).HasMaxLength(20);
            entity.Property(e => e.ObimGrudi).HasMaxLength(20);
            entity.Property(e => e.ObimStruka).HasMaxLength(20);
            entity.Property(e => e.Pluca).HasMaxLength(50);
            entity.Property(e => e.PromjenaNaKozi).HasMaxLength(50);
            entity.Property(e => e.Puls).HasMaxLength(20);
            entity.Property(e => e.Tezina).HasMaxLength(10);
            entity.Property(e => e.Tonzile).HasMaxLength(50);
            entity.Property(e => e.Visina).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Vrat).HasMaxLength(50);

            entity.HasOne(d => d.Pacijent).WithMany(p => p.SistematskiPregleds)
                .HasForeignKey(d => d.PacijentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pacijent_SistematskiPregled");
        });

        modelBuilder.Entity<Terapija>(entity =>
        {
            entity.HasKey(e => e.TerapijaId).HasName("PK__Terapija__0EA55396BA2EBC87");

            entity.ToTable("Terapija");

            entity.Property(e => e.Do).HasMaxLength(20);
            entity.Property(e => e.NazivLijeka).HasMaxLength(100);
            entity.Property(e => e.Od).HasMaxLength(20);
            entity.Property(e => e.Podsjetnik).HasMaxLength(250);
            entity.Property(e => e.Uputa).HasMaxLength(100);
        });

        modelBuilder.Entity<Termin>(entity =>
        {
            entity.HasKey(e => e.TerminId).HasName("PK__Termin__42126C95AF6329D6");

            entity.ToTable("Termin");

            entity.Property(e => e.Datum).HasMaxLength(20);
            entity.Property(e => e.Razlog).HasMaxLength(250);
            entity.Property(e => e.Vrijeme).HasMaxLength(20);

            entity.HasOne(d => d.Doktor).WithMany(p => p.Termins)
                .HasForeignKey(d => d.DoktorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Doktor_Termin");

            entity.HasOne(d => d.Pacijent).WithMany(p => p.Termins)
                .HasForeignKey(d => d.PacijentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pacijent_Termin");
        });

        modelBuilder.Entity<Uloga>(entity =>
        {
            entity.HasKey(e => e.UlogaId).HasName("PK__Uloga__DCAB23CBBD02E4BE");

            entity.ToTable("Uloga");

            entity.Property(e => e.Naziv).HasMaxLength(50);
            entity.Property(e => e.OpisUloge).HasMaxLength(250);
        });

        modelBuilder.Entity<Uputnica>(entity =>
        {
            entity.HasKey(e => e.UputnicaId).HasName("PK__Uputnica__B7A9184EDA3A6032");

            entity.ToTable("Uputnica");

            entity.Property(e => e.Datum).HasMaxLength(20);
            entity.Property(e => e.Naziv).HasMaxLength(250);
            entity.Property(e => e.Razlog).HasMaxLength(250);
        });

        modelBuilder.Entity<Vakcinacija>(entity =>
        {
            entity.HasKey(e => e.VakcinacijaId).HasName("PK__Vakcinac__79D399AC7A1EBC24");

            entity.ToTable("Vakcinacija");

            entity.Property(e => e.NazivVakcine).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
        modelBuilder.Seed();

    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
