using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models.User;

namespace WebAPI.Service.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<WebAPI.Models.User.UserDetails, UserDetailsDTO>();
            CreateMap<UserDetailsDTO, WebAPI.Models.User.UserDetails>();
        }
    }
}
