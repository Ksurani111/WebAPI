
using Microsoft.EntityFrameworkCore;
using WebAPI.Data.EF.Context;
using WebAPI.Data.EF.Interface;
using WebAPI.Models.User;


namespace WebAPI.Data.EF.Repository
{
    public class UserRepository : IUserRepository
    {
        private Db_Context context;

        public UserRepository(Db_Context context)
        {
            this.context = context;
        }
        public async Task<int> CreateUser(UserDetails userDetails)
        {
            context.UserDetails.Add(userDetails);
            return await context.SaveChangesAsync();
        }

        public async Task<List<UserDetails>> GetAllUser()
        {
            return await context.UserDetails.ToListAsync();
        }

        public Task<UserDetails> GetUser(Guid UserId)
        {
            throw new NotImplementedException();
        }
    }
}
