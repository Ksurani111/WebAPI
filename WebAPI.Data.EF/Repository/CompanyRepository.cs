using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Data.EF.Context;
using WebAPI.Data.EF.Interface;
using WebAPI.Models.Company;
using WebAPI.Models.User;

namespace WebAPI.Data.EF.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private Db_Context context;

        public CompanyRepository(Db_Context context)
        {
            this.context = context;
        }
        public async Task<int> Create(CompanyDetails companyDetails)
        {
            context.CompanyDetails.Add(companyDetails);
            return await context.SaveChangesAsync();
        }

        public async Task<CompanyDetails> Get(Guid CompanyId)
        {
            return await context.CompanyDetails?.FirstOrDefaultAsync(x=>x.Id == CompanyId);
        }

        public async Task<List<CompanyDetails>> GetAll()
        {
            return await context.CompanyDetails.ToListAsync();
        }
    }
}
