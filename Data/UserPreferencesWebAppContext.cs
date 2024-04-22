using Microsoft.EntityFrameworkCore;
using UserPreferencesWebApp.Models;

namespace UserPreferencesWebApp.Data
{
    public class UserPreferencesWebAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Preference> Preferences { get; set; }

        public UserPreferencesWebAppContext(DbContextOptions<UserPreferencesWebAppContext> options) : base(options) { }
    }
}
