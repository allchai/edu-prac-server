using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    [Table("lesson_time")]
    public class LessonTime
    {
        [Key]
        [Column("lesson_time_id")]
        public int LessonTimeID { get; set; }

        [Required]
        [Column("lesson_number")]
        public int LessonNumber { get; set; }

        [Required]
        [Column("time_start")]
        public TimeOnly TimeStart { get; set; }

        [Required]
        [Column("time_end")]
        public TimeOnly TimeEnd { get; set; }


    }
}
