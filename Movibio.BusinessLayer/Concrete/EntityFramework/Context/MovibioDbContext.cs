using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Movibio.BusinessLayer.Concrete.EntityFramework.Mapping;
using Movibio.DataLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.BusinessLayer.Concrete.EntityFramework.Context
{
    public class MovibioDbContext : IdentityDbContext<
        User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Scenarist> Scenarists { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }
        public DbSet<MovieDirector> MovieDirectors { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<MovieLanguage> MovieLanguages { get; set; }
        public DbSet<MovieScenarist> MovieScenarists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LOCALHOST\SQLEXPRESS;
                Database=Movibio;Trusted_Connection=True;
                Connect Timeout=30;MultipleActiveResultSets=True;");
        }

        //AutoMap
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new ExampleMap());


            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new RoleClaimMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
            modelBuilder.ApplyConfiguration(new UserTokenMap());
            modelBuilder.ApplyConfiguration(new UserLoginMap());
            modelBuilder.ApplyConfiguration(new UserClaimMap());

            modelBuilder.ApplyConfiguration(new MovieMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new ScenaristMap());
            modelBuilder.ApplyConfiguration(new CastMap());
            modelBuilder.ApplyConfiguration(new DirectorMap());
            modelBuilder.ApplyConfiguration(new GenreMap());
            modelBuilder.ApplyConfiguration(new LanguageMap());
            modelBuilder.ApplyConfiguration(new TrailerMap());
            modelBuilder.ApplyConfiguration(new PictureMap());

            modelBuilder.ApplyConfiguration(new MovieScenaristMap());
            modelBuilder.ApplyConfiguration(new MovieCastMap());
            modelBuilder.ApplyConfiguration(new MovieDirectorMap());
            modelBuilder.ApplyConfiguration(new MovieGenreMap());
            modelBuilder.ApplyConfiguration(new MovieLanguageMap());

        }
    }   
}
