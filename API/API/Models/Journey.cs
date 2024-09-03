using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Journey
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(6,2)")]
        public decimal Distance { get; set; }
        public ICollection<UserJourney> UserJourneys { get; set; } = new List<UserJourney>();
    }
}