using GaziKultur.Data.Concrete.EntityFramework;
using GaziKultur.Entity.Concrete;
using GaziKultur.Service.Abstract;
using System;
using System.Collections.Generic;

namespace GaziKultur.Service.Concrete.Manager
{
    public class KutuphaneManager : IKutuphaneService
    {
        private readonly EfKutuphaneRepository _kutuphaneRepository;

        public KutuphaneManager(EfKutuphaneRepository kutuphaneRepository)
        {
            _kutuphaneRepository = kutuphaneRepository;
        }

        public void Add(Kutuphane kutuphane)
        {
            _kutuphaneRepository.Add(kutuphane);
        }

        public void Delete(Guid id)
        {
            var kutuphane = _kutuphaneRepository.Get(x => x.KutuphaneID == id);

            if (kutuphane != null)
            {
                _kutuphaneRepository.Delete(kutuphane);
            }
        }

        public Kutuphane GetById(Guid id)
        {
            return _kutuphaneRepository.Get(x => x.KutuphaneID == id);
        }

        public List<Kutuphane> GetAll()
        {
            return _kutuphaneRepository.GetAll();
        }

        public void Update(Kutuphane kutuphane)
        {
            _kutuphaneRepository.Update(kutuphane);
        }
    }
}