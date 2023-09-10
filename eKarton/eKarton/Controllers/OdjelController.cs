using eKarton.Models.Model;
using eKarton.Services.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKarton.Controllers
{
    [Route("[controller]")]
    public class OdjelController : BaseController<Models.Model.Odjel, Models.Request.OdjelSearchRequest>
    {
        public OdjelController(ILogger<BaseController<Odjel, Models.Request.OdjelSearchRequest>> logger, IOdjelService service) : base(logger, service)
        {
        }
    }
}
