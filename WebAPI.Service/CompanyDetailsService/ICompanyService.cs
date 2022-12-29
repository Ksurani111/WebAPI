using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Service.CompanyDetailsService
{
    public interface ICompanyService
    {
        Task<List<WebAPI.Models.Company.CompanyDetails>> GetAllCompany();
    }
}
