using BugTrackerv4.Models;
using Microsoft.AspNetCore.Identity;

namespace BugTrackerv4.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Manager.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Supervisor.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Developer.ToString()));
        }

        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "test",
                Email = "test@tester.com",
                FirstName = "Test",
                LastName = "Tester",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word");
/*                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Developer.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Manager.ToString());*/
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Supervisor.ToString());
                }

            }
        }
    }
}
