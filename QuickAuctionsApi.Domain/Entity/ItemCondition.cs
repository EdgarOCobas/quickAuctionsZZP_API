namespace QuickAuctionsApi.Domain.Entity;

public class ItemCondition
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ItemCondition(string name)
    {
        Name = name;
    }
}