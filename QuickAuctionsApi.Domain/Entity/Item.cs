namespace QuickAuctionsApi.Domain.Entity;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ItemCategoryId { get; set; }
    public ItemCategory ItemCategory { get; set; }
    public int ItemConditionId { get; set; }
    public ItemCondition ItemCondition { get; set; } 
    public string Description { get; set; }
}