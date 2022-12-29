using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Data.EF.Interface;
using WebAPI.Models.Company;

namespace WebAPI.Service.CompanyDetailsService
{
    public class CompanyService : ICompanyService
    {
        private ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public async Task<List<CompanyDetails>> GetAllCompany()
        {
           return await _companyRepository.GetAll();
        }
    }
}
