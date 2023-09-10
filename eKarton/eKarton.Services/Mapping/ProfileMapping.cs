using AutoMapper;
using eKarton.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Services.Mapping
{
    public class ProfileMapping:Profile
    {
        public ProfileMapping() {
        
            CreateMap<Databases.Korisnik,Models.Model.Korisnik>();
            CreateMap<KorisnikSearchRequest,Databases.Korisnik>();
            CreateMap<KorisnikInsertRequest, Databases.Korisnik>();
            CreateMap<KorisnikUpdateRequest, Databases.Korisnik>();
            CreateMap<Databases.KorisnikUloga, Models.Model.KorisnikUloga>();

            CreateMap<Databases.Uloga, Models.Model.Uloga>();

            CreateMap<Databases.Administrator, Models.Model.Administrator>();
            CreateMap<AdministratorSearchRequest, Databases.Administrator>();

            CreateMap<Databases.Bolnica, Models.Model.Bolnica>();
            CreateMap<BolnicaSearchRequest, Databases.Bolnica>();

            CreateMap<Databases.Pacijent, Models.Model.Pacijent>();
            CreateMap<PacijentSearchRequest, Databases.Pacijent>();
            CreateMap<PacijentInsertRequest, Databases.Pacijent>();
            CreateMap<PacijentUpdateRequest, Databases.Pacijent>();

            CreateMap<Databases.Odjel, Models.Model.Odjel>();
            CreateMap<OdjelSearchRequest, Databases.Odjel>();

            CreateMap<Databases.Doktor, Models.Model.Doktor>();
            CreateMap<OdjelSearchRequest, Databases.Doktor>();

            CreateMap<Databases.PreventivneMjere, Models.Model.PreventivneMjere>();
            CreateMap<PreventivneMjereSearchRequest, Databases.PreventivneMjere>();
            CreateMap<PreventivneMjereInsertRequest, Databases.PreventivneMjere>();
            CreateMap<PreventivneMjereUpdateRequest, Databases.PreventivneMjere>();

            CreateMap<Databases.Uloga, Models.Model.Uloga>();
            CreateMap<Databases.DodjeljeniDoktor, Models.Model.DodjeljeniDoktor>();
            CreateMap<Databases.PreventivneMjere, Models.Model.PreventivneMjere>();
            CreateMap<Databases.Pregled, Models.Model.Pregled>();







        }
    }
}
