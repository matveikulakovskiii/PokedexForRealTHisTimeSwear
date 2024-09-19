using Microsoft.EntityFrameworkCore;
using PokedexForRealTHisTimeSwear.Data;

namespace PokedexForRealTHisTimeSwear.Models
{
    public class SeedData
    {
        public static void Initilize(IServiceProvider serviceProvider)
        {
            using (var context = new PokedexForRealTHisTimeSwearContext(serviceProvider.GetRequiredService<DbContextOptions<PokedexForRealTHisTimeSwearContext>>()))
            {
                if (context.Pokemon.Any())
                {
                    return;
                }
                context.Pokemon.AddRange(
                    new Pokemon
                    {
                        Name = "BulbaSaur",
                        DiscoveryRegion = "Kanto",
                        PokedexEntryId = 1,
                        ElementType = "Grass",
                        Gender = "Can appear as male or female",
                        ImageURL = "https://th.bing.com/th/id/OIP.KkDgveDGqbhGjJJhuo4d7gAAAA?w=150&h=147&c=7&r=0&o=5&pid=1.7"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
