using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ICFERApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Student> Students { get; set; }
    }
}