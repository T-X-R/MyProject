using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Tom",
                    Email = "Tom@example.com",
                    UserName = "Tom@example.com",
                    Address = new Address
                    {
                        FirstName = "Tom",
                        LastName = "Carol",
                        Street = "10 the street",
                        City = "San Francisco",
                        State = "CA",
                        ZipCode = "92123"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}