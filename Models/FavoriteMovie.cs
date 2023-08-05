namespace WebAPIFinal.Models
{
    public class FavoriteMovie
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public string MovieGenre { get; set; }
        public string MovieDirector { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}