using FlatRentService.Models;
using Microsoft.EntityFrameworkCore;

namespace FlatRentService.Data;

public class FlatDbContext : DbContext
{
    public FlatDbContext(DbContextOptions<FlatDbContext> options)
    : base(options)
    {
    }
    public DbSet<FlatDetails> FlatDetails { get; set; }
}