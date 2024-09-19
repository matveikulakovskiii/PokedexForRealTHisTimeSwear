using System.ComponentModel.DataAnnotations;

namespace PokedexForRealTHisTimeSwear.Models
{
    public class Pokemon
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        [Display(Name="Pokedex ID")]
        public int PokedexEntryId { get; set; }
        [Display(Name = "Region of discovery")]
        public string DiscoveryRegion { get; set; }
        [Display(Name = "Pokemon Type")]
        public string ElementType { get; set; }

        public string ImageURL { get; set; }
    }
}
