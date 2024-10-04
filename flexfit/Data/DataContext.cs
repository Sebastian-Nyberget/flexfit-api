using flexfit.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace flexfit.Data;

    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users {get;set;}
    }