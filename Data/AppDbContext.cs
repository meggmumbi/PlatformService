using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
public class AppDbContext : DbContext{
   public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)

   {
       
   } 
//define a dbset set that relates to the model
   public DbSet<Platform> Platforms {get;set;}
}
} 