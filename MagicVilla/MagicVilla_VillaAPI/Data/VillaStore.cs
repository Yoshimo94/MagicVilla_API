using MagicVilla_VillaAPI.Model.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villalist = new List<VillaDTO>()
            {
                new VillaDTO{Id = 1, Name ="Pool View", Occupancy = 4, Sqft = 100 },
                new VillaDTO{Id = 2, Name ="Beach View", Occupancy = 3, Sqft = 300 }
            };
    }
}
