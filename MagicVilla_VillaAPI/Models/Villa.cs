namespace MagicVilla_VillaAPI.Models
{
    public class Villa
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int sqft { get; set; }
        public string Occupany { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
