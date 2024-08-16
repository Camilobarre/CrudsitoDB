using CrudsitoEjemploDB.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudsitoEjemploDB.Database;

public class AplicationDbContext : DbContext
{
    public DbSet<Coder> Coders { get; set; }
    public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
    {
    }
}