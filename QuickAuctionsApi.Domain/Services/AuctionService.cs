using QuickAuctionsApi.Domain.Dto;
using QuickAuctionsApi.Domain.Entity;
using QuickAuctionsApi.Domain.Ports.In;
using QuickAuctionsApi.Domain.Ports.Out;

namespace QuickAuctionsApi.Domain.Services;

public class AuctionService : IGetAuctionsUseCase
{
    private readonly IAuctionRepository _auctionRepository;


    public AuctionService(IAuctionRepository auctionRepository)
    {
        _auctionRepository = auctionRepository;
    }

    public async Task<List<AuctionDetails>> GetAllAuctionsAsync()
    {
        return (await _auctionRepository.GetAuctionsAsync()).Select(c => c.ToDto()).ToList();
    }
}