using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ICollection<UserJourney> UserJourneys { get; set; } = new List<UserJourney>();
        public ICollection<DayTrip> DayTrips { get; set; } = new List<DayTrip>();
    }
}