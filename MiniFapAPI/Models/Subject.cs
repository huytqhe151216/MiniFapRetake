using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniFapAPI.Models
{
    [Table("Subject")]
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        [StringLength(100)]
        [Required]
        public string SubjectName { get; set; }
        public ICollection<Course> Courses { get; } = new List<Course>();
    }
}
