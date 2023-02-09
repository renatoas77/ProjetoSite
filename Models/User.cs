using Microsoft.AspNetCore.Identity;

namespace FighteR_PG.Models
{
    public class User : IdentityUser
    {
        public List<Team> Teams { get; set; }
    }
}
