using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Models.User
{
    public class UserDetailsDTO
    {
  
        public string? UserName { get; set; }
        public string? City { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
