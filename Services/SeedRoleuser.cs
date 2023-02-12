using FighteR_PG.Models;
using FighteR_PG.Services.IServices;
using Microsoft.AspNetCore.Identity;

namespace FighteR_PG.Services
{
    public class SeedRoleuser : ISeedRoleUser
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public void SeedRoles()
        {
            throw new NotImplementedException();
        }

        public void SeedUsers()
        {
            throw new NotImplementedException();
        }
    }
}
