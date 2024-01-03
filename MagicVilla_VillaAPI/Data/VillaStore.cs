using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto {Id=1,Name="Pool Villa",sqft=200,Occupany=4},
            new VillaDto {Id=2,Name="Beach View",sqft=150,Occupany=3}
        };
    }
}
