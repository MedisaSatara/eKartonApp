using eKarton.Models.Request;
using eKarton.Services.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKarton.Controllers
{
    [Route("[controller]")]
    public class PreventivneMjereController : BaseCRUDController<Models.Model.PreventivneMjere, Models.Request.PreventivneMjereSearchRequest, Models.Request.PreventivneMjereInsertRequest, Models.Request.PreventivneMjereUpdateRequest>
    {
        public PreventivneMjereController(ILogger<BaseController<Models.Model.PreventivneMjere, Models.Request.PreventivneMjereSearchRequest>> logger, IMjereService service) : base(logger, service)
        {
        }
        
        public override Task<Models.Model.PreventivneMjere> Insert([FromBody] PreventivneMjereInsertRequest insert)
        {
            return base.Insert(insert);
        }
        

    }
}
