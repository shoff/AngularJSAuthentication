namespace AngularJSAuthentication.API
{
    using System.Data.Entity;
    using Entities;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}