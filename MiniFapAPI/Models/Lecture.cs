using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniFapAPI.Models
{
    [Table("Lecture")]
    public class Lecture
    {
        [Key]
        public string LectureId { get; set; }
        public string LectureName { get; set; }
        public string UserId { get; set; }
        public AppUser? AppUser { get; set; }
        public ICollection<Course> Courses { get; } = new List<Course>();

    }
}
