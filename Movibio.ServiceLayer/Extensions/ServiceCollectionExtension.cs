using Microsoft.Extensions.DependencyInjection;
using Movibio.BusinessLayer.Concrete.EntityFramework.Context;
using Movibio.BusinessLayer.UnitOfWork;
using Movibio.DataLayer.Concrete;
using Movibio.ServiceLayer.Abstract;
using Movibio.ServiceLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection
            serviceCollection)
        {
            serviceCollection.AddDbContext<MovibioDbContext>();
            serviceCollection.AddIdentity<User, Role>(options =>
            {
                // Kullanıcı şifre ayarları
                options.Password.RequireDigit = false; // sayı kullanma zorunluluğu
                options.Password.RequiredLength = 5; // şifre en az kaç karakter olmalıdır
                options.Password.RequiredUniqueChars = 0; //özel karakter tane olmalıdır
                options.Password.RequireNonAlphanumeric = false; //özel karakter kullanma zorunluluğu
                options.Password.RequireLowercase = false; // küçük karakter kullanma zorunluluğu
                options.Password.RequireUppercase = false; // büyük karakter kullanma zorunluluğu

                // Kullanıcı adı ve email ayarları
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyz" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "0123456789" +
                "-._@+$";
                options.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<MovibioDbContext>();
            
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<IMovieService, MovieService>();
            serviceCollection.AddScoped<ICastService, CastService>();
            serviceCollection.AddScoped<IScenaristService, ScenaristService>();
            serviceCollection.AddScoped<IDirectorService, DirectorService>();
            serviceCollection.AddScoped<ICommentService, CommentService>();
            serviceCollection.AddScoped<IGenreService, GenreService>();
            serviceCollection.AddScoped<ILanguageService, LanguageService>();

            return serviceCollection;
        }
    }
}
