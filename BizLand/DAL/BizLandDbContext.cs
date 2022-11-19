using BizLand.Models;
using Microsoft.EntityFrameworkCore;

namespace BizLand.DAL
{
    public class BizLandDbContext:DbContext
    {
        public BizLandDbContext(DbContextOptions<BizLandDbContext>options):base(options)
        {

        }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Service> Services { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
