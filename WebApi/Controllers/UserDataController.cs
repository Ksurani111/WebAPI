using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebAPI.Models.Company;
using WebAPI.Models.User;
using WebAPI.Service.CompanyDetailsService;
using WebAPI.Service.UserDetailsService;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDataController : ControllerBase
    {
        private IUserService _userService;

        public UserDataController(IUserService userService)
        {
            _userService = userService;
             
        }

        [HttpGet("GetUsers")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<UserDetails>> GetUser()
        {
            var result = await _userService.GetAllUser();
            return Ok(result);
        }

        [HttpPost("CreateUser")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateUser(UserDetailsDTO userDetailsDTO)
        {
            var result = await _userService.CreateAllUser(userDetailsDTO);
            return Ok(result);
        }
        }
}
