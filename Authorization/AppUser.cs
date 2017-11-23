using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Authorization
{
    public class AppUser: IdentityUser<int,MyLogin,MyUserRole,MyClaim>
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser,int> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class MyUserRole: IdentityUserRole<int> { }

    public class MyRole: IdentityRole<int, MyUserRole> { }
    public class MyClaim: IdentityUserClaim<int> { }
    public class MyLogin: IdentityUserLogin<int> { }
}