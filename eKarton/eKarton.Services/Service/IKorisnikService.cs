using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Services.Service
{
    public interface IKorisnikService : ICRUDService<Models.Model.Korisnik, Models.Request.KorisnikSearchRequest, Models.Request.KorisnikInsertRequest,Models.Request.KorisnikUpdateRequest>
    {
        public Task<Models.Model.Korisnik> Login(string username, string password);
    }
}
