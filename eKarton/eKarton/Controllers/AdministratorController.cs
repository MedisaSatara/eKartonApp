using eKarton.Models.Model;
using eKarton.Models.Request;
using eKarton.Services.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKarton.Controllers
{
    [Route("[controller]")]
    public class AdministratorController : BaseController<Models.Model.Administrator, Models.Request.AdministratorSearchRequest>
    {
        public AdministratorController(ILogger<BaseController<Administrator, Models.Request.AdministratorSearchRequest>> logger, IAdministratorService service) : base(logger, service)
        {
        }
    }
}
