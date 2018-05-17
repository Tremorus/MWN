using Microsoft.AspNetCore.Identity;

namespace MyNotes.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        


    }
}
