using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebAPI.Models.Company;
using WebAPI.Service.CompanyDetailsService;

namespace WebApi.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]

  
    public class CompanyDataController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyDataController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("GetCompanies")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<CompanyDetails>> GetCompanies()
        {
            var result = await _companyService.GetAllCompany();
            return Ok(result);
        }

    }
}
