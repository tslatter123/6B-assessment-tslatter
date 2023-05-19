using SixBAssessmentTSlatter.Server.Models;
using Microsoft.AspNetCore.Identity;

namespace SixBAssessmentTSlatter.Server.Data
{
    public class SeedData
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public SeedData(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task RunSeed()
        {
            if (await _userManager.FindByEmailAsync("user@6b.tst") == null)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = "user@6b.tst",
                    Email = "user@6b.tst",
                    EmailConfirmed = true
                };
                var result = await _userManager.CreateAsync(user, "Testing123!");
            }
        }
    }
}
