using Microsoft.EntityFrameworkCore;
using WebAPI.Models.Company;
using WebAPI.Models.User;

namespace WebAPI.Data.EF.Context
{
    public class Db_Context : DbContext
    {
        public Db_Context(DbContextOptions<Db_Context> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<UserDetails> UserDetails { get; set; }

        public DbSet<CompanyDetails> CompanyDetails { get; set; }
    }
}
