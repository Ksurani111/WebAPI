using WebAPI.Models.User;

namespace WebAPI.Data.EF.Interface
{
    public interface IUserRepository
    {
        Task<List<UserDetails>> GetAllUser();
        Task<UserDetails> GetUser(Guid UserId);
        Task<int> CreateUser(UserDetails userDetails);
    }
}
