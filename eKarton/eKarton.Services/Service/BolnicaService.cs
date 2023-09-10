using AutoMapper;
using eKarton.Models.Model;
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
    public class BolnicaService : BaseService<Models.Model.Bolnica, Databases.Bolnica, BolnicaSearchRequest>, IBolnicaService
    {
        public BolnicaService(EKartonContext context, IMapper mapper)
        : base(context, mapper)
        {
        }


        public override IQueryable<Databases.Bolnica> AddInclude(IQueryable<Databases.Bolnica> query, BolnicaSearchRequest? search = null)
        {
            if (search?.isAdministratorIncluded == true)
            {
                query = query.Include("Administrators");
            }
            return base.AddInclude(query, search);
        }
    }
}
