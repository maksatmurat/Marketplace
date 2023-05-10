using Microsoft.EntityFrameworkCore;
using Shared.Models;
using System.Collections.Generic;

namespace Plugins.DataStore.SQLITE;

public sealed class MarketDbContext : DbContext
{
    public DbSet<Category>? Categories { get; set; }
    
    public MarketDbContext(DbContextOptions<MarketDbContext> opt) : base(opt)
    {

    }
}
