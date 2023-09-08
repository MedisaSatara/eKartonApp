using eKarton.Models.Model;
using eKarton.Models.Request;
using eKarton.Services.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace eKarton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : BaseCRUDController<Models.Model.Korisnik, Models.Request.KorisnikSearchRequest, Models.Request.KorisnikInsertRequest, Models.Request.KorisnikUpdateRequest>
    {
        public KorisnikController(ILogger<BaseController<Models.Model.Korisnik, Models.Request.KorisnikSearchRequest>> logger, IKorisnikService service) : base(logger, service)
        {
        }

        public override Task<Models.Model.Korisnik> Insert([FromBody] KorisnikInsertRequest insert)
        {
            return base.Insert(insert);
        }

    }
}
