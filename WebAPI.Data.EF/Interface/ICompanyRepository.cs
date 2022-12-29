using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models.Company;

namespace WebAPI.Data.EF.Interface
{
    public interface ICompanyRepository
    {
        Task<List<CompanyDetails>> GetAll();
        Task<CompanyDetails> Get(Guid UserId);
        Task<int> Create(CompanyDetails companyDetails);
    }
}
