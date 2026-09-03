using System;
using System.Collections.Generic;
using GaziKultur.Entity.Concrete;

namespace GaziKultur.Service.Abstract
{
    public interface IKutuphaneService
    {
        List<Kutuphane> GetAll();
        Kutuphane GetById(Guid id);
        void Add(Kutuphane kutuphane);
        void Update(Kutuphane kutuphane);
        void Delete(Guid id);
    }
}
