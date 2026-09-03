using GaziKultur.Entity.Concrete;

namespace GaziKultur.Data.Concrete.EntityFramework
{
    public class EfKutuphaneRepository
        : EfEntityRepositoryBase<Kutuphane, GaziKulturContext>
    {
        public EfKutuphaneRepository(GaziKulturContext context)
            : base(context)
        {
        }
    }
}