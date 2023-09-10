using eKarton.Models.Request;
using eKarton.Services.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKarton.Controllers
{
    [Route("[controller]")]
    public class BolnicaController : BaseController<Models.Model.Bolnica, Models.Request.BolnicaSearchRequest>
    {
        public BolnicaController(ILogger<BaseController<Models.Model.Bolnica, Models.Request.BolnicaSearchRequest>> logger
             , IService<Models.Model.Bolnica, Models.Request.BolnicaSearchRequest> service) : base(logger, service)
        {
        }
    }
}
