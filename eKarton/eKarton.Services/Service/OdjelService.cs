using AutoMapper;
using eKarton.Models.Request;
using eKarton.Services.Databases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace eKarton.Services.Service
{
    public class OdjelService : BaseService<Models.Model.Odjel, Databases.Odjel, OdjelSearchRequest>, IOdjelService
    {
        public OdjelService(EKartonContext context, IMapper mapper)
        : base(context, mapper)
        {
        }


        public override IQueryable<Databases.Odjel> AddFilter(IQueryable<Databases.Odjel> query, OdjelSearchRequest? search = null)
        {
            if (!string.IsNullOrWhiteSpace(search?.NazivOdjela))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.NazivOdjela));
            }
            if (search?.IsIncludeDoktor == true)
            {
                query = query.Include(x => x.Doktors);
            }


            return base.AddFilter(query, search);
        }
        
    }
}
