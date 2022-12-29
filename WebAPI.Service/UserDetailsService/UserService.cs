using AutoMapper;
using WebAPI.Data.EF.Interface;
using WebAPI.Service.UserDetailsService;

namespace WebAPI.Service.UserDetails
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<List<Models.User.UserDetails>> GetAllUser()
        {
            return await _userRepository.GetAllUser();
        }
        public async Task<int> CreateAllUser(Models.User.UserDetailsDTO userDetailsDTO)
        {
            var userdetails = _mapper.Map<Models.User.UserDetails>(userDetailsDTO);
            userdetails.Id = Guid.NewGuid();
            return await _userRepository.CreateUser(userdetails);
        }
    }
}
