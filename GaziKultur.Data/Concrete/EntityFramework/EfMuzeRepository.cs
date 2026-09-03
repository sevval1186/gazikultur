using GaziKultur.Entity.Concrete;

namespace GaziKultur.Data.Concrete.EntityFramework
{
    public class EfMuzeRepository
        : EfEntityRepositoryBase<Muze, GaziKulturContext>
    {
        public EfMuzeRepository(GaziKulturContext context)
            : base(context)
        {
        }
    }
}