using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    [Table("weekday")]
    public class Weekday
    {
        [Key]
        [Column("weekday_id")]
        public int WeekdayId { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; } = null!;
    }
}
