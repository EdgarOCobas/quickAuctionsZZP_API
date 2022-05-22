using QuickAuctionsApi.Domain.Dto;
using QuickAuctionsApi.Domain.Entity;

namespace QuickAuctionsApi.Domain.Ports.In;

public interface IGetAuctionsUseCase
{
    Task<List<AuctionDetails>> GetAllAuctionsAsync();
}