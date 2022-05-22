using Microsoft.EntityFrameworkCore;
using QuickAuctionsApi.Domain.Entity;

namespace QuickAuctionsApi.Infrastructure.Database;

public class QuickAuctionsContext : DbContext
{
    public QuickAuctionsContext(DbContextOptions options) : base(options)
    {
        
    }
    public virtual DbSet<ItemCategory> Categories { get; set; }
    public virtual DbSet<ItemCondition> Conditions { get; set; }
    public virtual DbSet<Item> Items { get; set; }
    public virtual DbSet<Auction> Auctions { get; set; }
}
