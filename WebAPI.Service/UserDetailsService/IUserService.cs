namespace WebAPI.Service.UserDetailsService
{
    public interface IUserService
    {
        Task<List<WebAPI.Models.User.UserDetails>> GetAllUser();
        Task<int> CreateAllUser(Models.User.UserDetailsDTO userDetailsDTO);

    }
}
