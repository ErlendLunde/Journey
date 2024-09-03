using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class UserJourney
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int JourneyId { get; set; }
        public Journey Journey { get; set; } = null!;
    }
}