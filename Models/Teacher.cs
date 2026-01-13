using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    [Table("teacher")]
    public class Teacher
    {
        [Key]
        [Column("teacher_id")]
        public int TeacherId { get; set; }

        [Required]
        [Column("last_name")]
        public string LastName { get; set; } = null!;

        [Required]
        [Column("first_name")]
        public string FirstName { get; set; } = null!;

        [Column("middle_name")]
        public string MiddleName { get; set; } = null!;

        [Required]
        public string Position { get; set; } = null!;
    }
}
