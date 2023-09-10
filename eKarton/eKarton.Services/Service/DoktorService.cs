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
    public class DoktorService : BaseService<Models.Model.Doktor, Databases.Doktor, OdjelSearchRequest>, IDoktorService
    {
        public DoktorService(EKartonContext context, IMapper mapper)
            : base(context, mapper)
        {

        }


        public override IQueryable<Databases.Doktor> AddFilter(IQueryable<Databases.Doktor> query, OdjelSearchRequest? search = null)
        {
            if (!string.IsNullOrWhiteSpace(search?.ImeDoktora))
            {
                query = query.Where(x => x.Ime.StartsWith(search.ImeDoktora));
            }
            if (!string.IsNullOrWhiteSpace(search?.PrezimeDoktora))
            {
                query = query.Where(x => x.Prezime.StartsWith(search.PrezimeDoktora));
            }
            if (!string.IsNullOrWhiteSpace(search?.NazivOdjela))
            {
                query = query.Where(x => x.Odjel.Naziv == search.NazivOdjela);
            }

            return base.AddFilter(query, search);
        }

      
    }
}
