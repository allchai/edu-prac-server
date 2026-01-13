using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    [Table("subject")]
    public class Subject
    {
        [Key]
        [Column("subject_id")]
        public int SubjectId { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; } = null!;
     }
}
