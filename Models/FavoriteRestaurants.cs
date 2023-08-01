namespace WebAPIFinal.Models
{
    public class FavoriteRestaurants
    {
        public int id { get; set; }
        public string NameOfRestaurnt { get; set; }
        public string FavoriteMeal { get; set; }
        public string Location { get; set; }
        public DateTime DayLastVisited { get; set; }
    }
}
