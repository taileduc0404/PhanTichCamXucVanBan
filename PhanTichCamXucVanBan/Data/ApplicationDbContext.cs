using Microsoft.EntityFrameworkCore;
using PhanTichCamXucVanBan.Models;

namespace PhanTichCamXucVanBan.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CamXuc> camXucs { get; set; }
    }
}
