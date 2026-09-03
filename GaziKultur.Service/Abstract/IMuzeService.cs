using System;
using System.Collections.Generic;
using GaziKultur.Entity.Concrete;

namespace GaziKultur.Service.Abstract
{
    public interface IMuzeService
    {
        List<Muze> GetAll();
        Muze GetById(Guid id);
        void Add(Muze muze);
        void Update(Muze muze);
        void Delete(Guid id);
    }
}
