using AutoMapper;
using eKarton.Models.Request;
using eKarton.Services.Databases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Services.Service
{
    public class PreventivneMjereService : BaseCRUDService<Models.Model.PreventivneMjere, Databases.PreventivneMjere, PreventivneMjereSearchRequest, PreventivneMjereInsertRequest, PreventivneMjereUpdateRequest>, IMjereService
    {
        public PreventivneMjereService(EKartonContext context, IMapper mapper)
        : base(context, mapper)
        {
        }

        public override IQueryable<Databases.PreventivneMjere> AddInclude(IQueryable<Databases.PreventivneMjere> query, PreventivneMjereSearchRequest? search = null)
        {
            if (search?.isPacijentIncluded == true)
            {
                query = query.Include("Pacijent");
            }
            return base.AddInclude(query, search);
        }
        public override IQueryable<Databases.PreventivneMjere> AddFilter(IQueryable<Databases.PreventivneMjere> query, PreventivneMjereSearchRequest? search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search?.isPacijentIncluded == true)
            {
                query = query.Include(x => x.Pacijent);
            }

            return filteredQuery;
        }

    }
}
