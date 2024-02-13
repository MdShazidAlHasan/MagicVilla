using Microsoft.EntityFrameworkCore;
using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options)
        :base(options)
        {
        }
        public DbSet<Villa> Villas { get; set; }
    }
}
