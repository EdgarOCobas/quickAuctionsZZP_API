using Microsoft.EntityFrameworkCore;
using QuickAuctionsApi.Domain.Entity;
using QuickAuctionsApi.Domain.Ports.Out;

namespace QuickAuctionsApi.Infrastructure.Database;

public class AuctionRepository : IAuctionRepository
{
    private readonly QuickAuctionsContext _context;

    public AuctionRepository(QuickAuctionsContext context)
    {
        _context = context;
    }

    public async Task<List<Auction>> GetAuctionsAsync()
    {
        var query = _context.Auctions
            .Include(c => c.Item).ThenInclude(c => c.ItemCategory)
            .Include(c => c.Item).ThenInclude(c => c.ItemCondition);
        return await query.ToListAsync();
    }
}