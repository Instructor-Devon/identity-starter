using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityTest.Models
{
    public class MyContext : IdentityDbContext<User>
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public new DbSet<User> Users {get;set;}
        public DbSet<Message> Messages {get;set;}
    }
}