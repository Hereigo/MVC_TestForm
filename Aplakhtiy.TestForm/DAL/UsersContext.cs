using Aplakhtiy.TestForm.Models;
using System.Data.Entity;

namespace Aplakhtiy.TestForm.DAL
{
    public class UsersContext : DbContext
    {
        public UsersContext() : base("UsersDb")
        {
            Database.SetInitializer<UsersContext>(new CreateDatabaseIfNotExists<UsersContext>());
        }

        public DbSet<User> Users { get; set; }
    }
}