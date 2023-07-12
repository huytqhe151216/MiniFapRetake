using System.ComponentModel.DataAnnotations.Schema;

namespace MiniFapAPI.Models
{
    [Table("Student")]
    public class Student
    {
        public string StudentId { get; set; }
        public string StudentName { get; set;}
        public string UserId { get; set;}
        public int ClassId { get; set;}
        public Class Class { get; set;}
        public AppUser? AppUser { get; set; } 

    }
}
