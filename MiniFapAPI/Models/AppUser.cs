using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;

namespace MiniFapAPI.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName{get;set;}
    }
}
