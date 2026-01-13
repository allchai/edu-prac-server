using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    [Table("student_group")]
    public class StudentGroup
    {
        [Key]
        [Column("group_id")]
        public int GroupID { get; set; }

        [Required]
        [Column("group_name")]
        public string GroupName { get; set; } = null!;

        [Required]
        [Column("course")]
        public int Course { get; set; }

        [Required]
        [Column("specialty_id")]
        public int SpecialtyId { get; set; }

        [ForeignKey("SpecialtyId")]
        public Specialty Specialty { get; set; } = null!;
    }
}
