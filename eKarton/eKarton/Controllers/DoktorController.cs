using eKarton.Models.Model;
using eKarton.Services.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKarton.Controllers
{
    [Route("[controller]")]
    public class DoktorController : BaseController<Models.Model.Doktor, Models.Request.OdjelSearchRequest>
    {
        public DoktorController(ILogger<BaseController<Doktor, Models.Request.OdjelSearchRequest>> logger, IDoktorService service) : base(logger, service)
        {
        }
    }
}
