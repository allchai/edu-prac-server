using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    [Table("classroom")]
    public class Classroom
    {
        [Key]
        [Column("classroom_id")]
        public int ClassroomID { get; set; }

        [Required]
        [Column("building_id")]
        public int BuildingId { get; set; }

        [ForeignKey("BuildingId")]
        public Building Building { get; set; } = null!;

        [Required]
        [Column("room_number")]
        public string RoomNumber { get; set; } = null!;
    }
}
