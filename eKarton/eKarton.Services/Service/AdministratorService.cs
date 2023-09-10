using AutoMapper;
using eKarton.Models.Request;
using eKarton.Services.Databases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Services.Service
{
    public class AdministratorService : BaseService<Models.Model.Administrator, Databases.Administrator, AdministratorSearchRequest>, IAdministratorService
    {
        public AdministratorService(EKartonContext context, IMapper mapper)
            : base(context, mapper)
        {

        }


        public override IQueryable<Databases.Administrator> AddFilter(IQueryable<Databases.Administrator> query, AdministratorSearchRequest? search = null)
        {
            if (!string.IsNullOrWhiteSpace(search?.ImeAdministratora))
            {
                query = query.Where(x => x.Ime.StartsWith(search.ImeAdministratora));
            }
            if (!string.IsNullOrWhiteSpace(search?.PrezimeAdministratora))
            {
                query = query.Where(x => x.Prezime.StartsWith(search.PrezimeAdministratora));
            }

            return base.AddFilter(query, search);
        }
    }
}
