namespace WebAPIFinal.Models
{

    public class SpongeBobCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public DateTime FirstAppearance { get; set; }
        public string VoicedBy { get; set; }
    }
}