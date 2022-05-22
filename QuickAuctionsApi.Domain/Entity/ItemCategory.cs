namespace QuickAuctionsApi.Domain.Entity;

public class ItemCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ItemCategory(string name)
    {
        Name = name;
    }
}