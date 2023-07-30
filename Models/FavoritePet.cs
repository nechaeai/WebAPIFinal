namespace WebAPIFinal.Models{
    public class FavoritePet
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Owner { get; set; }
        public string Breed { get; set; }
        public DateTime DOB { get; set; }
        public string FavoriteFood { get; set; }
    }
}