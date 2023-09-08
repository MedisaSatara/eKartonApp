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


        }
    }
}
