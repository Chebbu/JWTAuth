using JWTAuth.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWTAuth.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext (options)
    {
        public DbSet<User> Users { get; set; }
    }
}
