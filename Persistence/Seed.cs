using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Items.Any()) return;
            
            var items = new List<Item>
            {
                new Item
                {
                    Name = "Bleach Vol. 1",
                    Date = DateTime.UtcNow,
                    Description = "Vol 1 of Bleach",
                    Type = "cbz",
                    Location = "/BLEACH01"
                },
                new Item
                {
                    Name = "Bleach Vol. 2",
                    Date = DateTime.UtcNow,
                    Description = "Vol 2 of Bleach",
                    Type = "cbz",
                    Location = "/BLEACH02"
                },
                new Item
                {
                    Name = "Bleach Vol. 3",
                    Date = DateTime.UtcNow,
                    Description = "Vol 3 of Bleach",
                    Type = "cbz",
                    Location = "/BLEACH03"
                },
                new Item
                {
                    Name = "Bleach Vol. 4",
                    Date = DateTime.UtcNow,
                    Description = "Vol 4 of Bleach",
                    Type = "cbz",
                    Location = "/BLEACH04"
                },
                new Item
                {
                    Name = "Bleach Vol. 4",
                    Date = DateTime.UtcNow,
                    Description = "Vol 4 of Bleach",
                    Type = "cbz",
                    Location = "/BLEACH04"
                },
                new Item
                {
                    Name = "Bleach Vol. 5",
                    Date = DateTime.UtcNow,
                    Description = "Vol 5 of Bleach",
                    Type = "cbz",
                    Location = "/BLEACH05"
                },
            };

            await context.Items.AddRangeAsync(items);
            await context.SaveChangesAsync();
        }
    }
}