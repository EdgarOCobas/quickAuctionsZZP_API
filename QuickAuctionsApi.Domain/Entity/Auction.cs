using QuickAuctionsApi.Domain.Dto;

namespace QuickAuctionsApi.Domain.Entity;

public class Auction
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ItemId { get; set; }
    public Item Item { get; set; }
    public int CreatorId { get; set; }
    public int StartingPrice { get; set; }
    public int? CurrentPrice { get; set; }
    public int? CurrentWinnerId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsFinished { get; set; }
    public int MinimumBid { get; set; }

    public AuctionDetails ToDto()
    {
        return new AuctionDetails
        {
            Id = Id,
            ItemName = Item.Name,
            StartingPrice = StartingPrice,
            CurrentPrice = CurrentPrice,
            CurrentWinner = CurrentWinnerId,
            EndDate = EndDate,
        };
    }
}