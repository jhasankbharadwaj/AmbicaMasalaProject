using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace AmbicaMasala.Services.AuthApi.Data
{
    public class AmbicaAuthContext:DbContext
    {
        public AmbicaAuthContext(DbContextOptions options):base(options) { }

        DbSet<Register> registers { get; set; }


    }
}
