using GaziKultur.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace GaziKultur.Data.Concrete.EntityFramework
{
    public class GaziKulturContext : DbContext
    {
        public GaziKulturContext(DbContextOptions<GaziKulturContext> options)
            : base(options)
        {
        }

        public DbSet<Muze> Muzeler { get; set; }
    }
}
