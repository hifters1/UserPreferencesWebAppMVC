using Microsoft.EntityFrameworkCore;
using UserPreferencesWebApp.Models;

namespace UserPreferencesWebApp.Data
{
    //Defines the type of sets that can be queried from the database
    public class UserPreferencesWebAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Preference> Preferences { get; set; }

        public UserPreferencesWebAppContext(DbContextOptions<UserPreferencesWebAppContext> options) : base(options) { }
    }
}
