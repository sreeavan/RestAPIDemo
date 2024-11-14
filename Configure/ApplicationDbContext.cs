
using Microsoft.EntityFrameworkCore;
using UserApi.Models;

namespace UserApi.Configure;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
}