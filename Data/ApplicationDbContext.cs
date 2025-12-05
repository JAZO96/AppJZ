using AppJZ.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppJZ.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // === MAPEO USUARIO A TABLA EXISTENTE ===
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("usuario");

                entity.Property(e => e.Id)
                      .HasColumnName("id");

                entity.Property(e => e.Email)
                      .HasColumnName("email");

                entity.Property(e => e.UserName)
                      .HasColumnName("email"); // Username = email

                // Identity no usa tu campo "contraseña"
                entity.Ignore(e => e.PasswordHash);
            });

            // Opcional: renombrar tablas de Identity
            builder.Entity<IdentityRole>().ToTable("roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("usuario_rol");
            builder.Entity<IdentityUserClaim<string>>().ToTable("usuario_claims");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("roles_claims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("usuario_login");
            builder.Entity<IdentityUserToken<string>>().ToTable("usuario_tokens");
        }
    }
}
