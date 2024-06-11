using Ispit.API.Model.Base;
using Ispit.API.Model.Dbo;
using Ispit.API.Model.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Ispit.API.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<ShoppingItem> ShoppingItems { get; set; }
    }
}
