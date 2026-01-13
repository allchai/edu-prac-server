using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    [Table("specialties")]
    public class Specialty
    {
        [Key]
        [Column("id")]
        public int SpecialtyId { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

    }
}
