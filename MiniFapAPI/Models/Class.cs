using Microsoft.Extensions.Hosting;

namespace MiniFapAPI.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public ICollection<Student> Students { get; } = new List<Student>();
    }
}
