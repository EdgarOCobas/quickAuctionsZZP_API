using QuickAuctionsApi.Domain.Entity;

namespace QuickAuctionsApi.Infrastructure.Database;

public class DbInitializer
{
     public static async Task Initialize(QuickAuctionsContext context)
        {
            if (context.Auctions.Any()) return;

            var categories = new List<ItemCategory>
            {
                new ItemCategory("Alkohole"),
                new ItemCategory("Luksusowe"),
                new ItemCategory("Elektronika"),
                new ItemCategory("Ubrania"),
                new ItemCategory("Samochody"),
                new ItemCategory("Domy")
            };

            var conditions = new List<ItemCondition>
            {
                new ItemCondition("Nowy"),
                new ItemCondition("Lekko używany"),
                new ItemCondition("Mocno używany"),
                new ItemCondition("Zniszczony"),
            };

            var items = new List<Item>
            {
                new Item
                {
                    Name = "Gucci",
                    ItemCategoryId = 2,
                    ItemConditionId = 2,
                    Description = "S",
                },
                new Item
                {
                    Name = "Szyna",
                    ItemCategoryId = 4,
                    ItemConditionId = 1,
                    Description = "Super szyna",
                },
                new Item
                {
                    Name = "Nóż",
                    ItemCategoryId = 2,
                    ItemConditionId = 1,
                    Description = "Super szyna",
                },
                new Item
                {
                    Name = "Chivas regal",
                    ItemCategoryId = 1,
                    ItemConditionId = 1,
                    Description = "Chivas",
                },
            };
            
            var auctions = new List<Auction>
            {
                new Auction
                {
                     Name = "Baton Deluxe Aukcja Okazja",
                     ItemId = 1,
                     CreatorId = 2,
                     StartingPrice = 200,
                     CurrentPrice = 300,
                     CurrentWinnerId =  null,
                     StartDate = DateTime.Now,
                     EndDate = DateTime.Now.AddMonths(1),
                     IsFinished = false,
                     MinimumBid = 10,
                },
                new Auction
                {
                    Name = "Szynka Deluxe",
                    ItemId = 2,
                    CreatorId = 3,
                    StartingPrice = 200,
                    CurrentPrice = 300,
                    CurrentWinnerId = 2,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddMonths(1),
                    IsFinished = false,
                    MinimumBid = 10,
                },
                new Auction
                {
                    Name = "Nóż",
                    ItemId = 3,
                    CreatorId = 2,
                    StartingPrice = 200,
                    CurrentPrice = 300,
                    CurrentWinnerId = 2,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddMonths(1),
                    IsFinished = false,
                    MinimumBid = 10,
                },
                new Auction
                {
                    Name = "Piwko",
                    ItemId = 4,
                    CreatorId = 2,
                    StartingPrice = 100,
                    CurrentPrice = 1200,
                    CurrentWinnerId = null,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddMonths(1),
                    IsFinished = false,
                    MinimumBid = 100,
                },
            };

            await context.Categories.AddRangeAsync(categories);
            await context.Conditions.AddRangeAsync(conditions);
            await context.SaveChangesAsync();
            await context.Items.AddRangeAsync(items);
            await context.SaveChangesAsync();
            await context.Auctions.AddRangeAsync(auctions);
            await context.SaveChangesAsync();
        }
}