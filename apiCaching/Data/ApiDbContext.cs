using Microsoft.EntityFrameworkCore;

namespace apiCaching; 

public class ApiDbContext : DbContext
{
    public DbSet<Driver> Drivers {set;get;}

    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) {}

    


}