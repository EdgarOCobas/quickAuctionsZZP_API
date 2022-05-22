using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace QuickAuctionsApi.Domain.Dto;

public class AuctionDetails
{
    [JsonPropertyName(("id"))]
    [Required, Range(0, long.MaxValue)]
    public int Id { get; set; }
    [JsonPropertyName(("itemName"))]
    public string ItemName { get; set; }
    [JsonPropertyName(("startingPrice"))]
    public int StartingPrice { get; set; }
    [JsonPropertyName(("currentPrice"))]
    public int? CurrentPrice { get; set; }
    [JsonPropertyName(("currentWinner"))]
    public int? CurrentWinner { get; set; }
    [JsonPropertyName(("endDate"))]
    public DateTime EndDate { get; set; }
}