using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Services.Service
{
    public interface IAdministratorService : IService<Models.Model.Administrator, Models.Request.AdministratorSearchRequest>
    {
    }
}
