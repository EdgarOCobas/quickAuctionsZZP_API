using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using QuickAuctionsApi.Domain.Dto;
using QuickAuctionsApi.Domain.Entity;
using QuickAuctionsApi.Domain.Ports.In;

namespace QuickAuctionsApi.Controllers;

[Route("api/auctions")]
[ApiController]
public class AuctionController : Controller
{
    private readonly IGetAuctionsUseCase _getAuctionsUseCase;


    public AuctionController(IGetAuctionsUseCase getAuctionsUseCase)
    {
        _getAuctionsUseCase = getAuctionsUseCase;
    }

    [HttpGet]
    public async Task<ActionResult<List<Auction>>> GetAuctionsList()
    {
        var auctions = await _getAuctionsUseCase.GetAllAuctionsAsync();
        return Ok(new AuctionsResponse() {AuctionsCount = auctions.Count, Auctions = auctions});
    }

    public class AuctionsResponse
    {
        [JsonPropertyName("auctionsCount")]
        [Required, Range(0, long.MaxValue)]
        public int AuctionsCount { get; set; }
        [Required]
        [JsonPropertyName("auctions")]
        public List<AuctionDetails> Auctions { get; set; }
    }
}