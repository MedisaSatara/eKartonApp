using eKarton.Models.Request;
using eKarton.Services.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKarton.Controllers
{
    [Route("[controller]")]
    public class PacijentController : BaseCRUDController<Models.Model.Pacijent, Models.Request.PacijentSearchRequest, Models.Request.PacijentInsertRequest, Models.Request.PacijentUpdateRequest>
    {
        public PacijentController(ILogger<BaseController<Models.Model.Pacijent, Models.Request.PacijentSearchRequest>> logger, IPacijentService service) : base(logger, service)
        {
        }

        public override Task<Models.Model.Pacijent> Insert([FromBody] PacijentInsertRequest insert)
        {
            return base.Insert(insert);
        }

    }
}
