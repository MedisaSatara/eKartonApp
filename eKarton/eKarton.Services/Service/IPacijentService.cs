using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Services.Service
{
    public interface IPacijentService : ICRUDService<Models.Model.Pacijent, Models.Request.PacijentSearchRequest, Models.Request.PacijentInsertRequest, Models.Request.PacijentUpdateRequest>
    {
    }
}
