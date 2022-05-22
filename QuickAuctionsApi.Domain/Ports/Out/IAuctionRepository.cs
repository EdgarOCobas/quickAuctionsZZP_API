using QuickAuctionsApi.Domain.Dto;
using QuickAuctionsApi.Domain.Entity;

namespace QuickAuctionsApi.Domain.Ports.Out;

public interface IAuctionRepository
{
    Task<List<Auction>> GetAuctionsAsync();
}