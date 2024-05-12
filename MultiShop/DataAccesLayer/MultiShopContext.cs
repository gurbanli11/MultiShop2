using Microsoft.EntityFrameworkCore;
using WebApplication1.Areas.Admin.Models;
using MultiShop.Models;

namespace WebApplication1.DataAccesLayer
{
    public class MultiShopContext : DbContext
    {
        public MultiShopContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sliders> Sliders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=CLASSOSERAMICEU\\SQLEXPRESS01;DataBase=Phonia106;Trusted_Connection=true;TrustServerCertificate=True");
            base.OnConfiguring(options);
        }
    }
}
