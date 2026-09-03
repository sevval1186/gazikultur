using GaziKultur.Data.Concrete.EntityFramework;
using GaziKultur.Entity.Concrete;
using GaziKultur.Service.Abstract;
using System;
using System.Collections.Generic;

namespace GaziKultur.Service.Concrete.Manager
{
    public class MuzeManager : IMuzeService
    {
        private readonly EfMuzeRepository _muzeRepository;

        public MuzeManager(EfMuzeRepository muzeRepository)
        {
            _muzeRepository = muzeRepository;
        }

        public void Add(Muze muze)
        {
            _muzeRepository.Add(muze);
        }

        public void Delete(Guid id)
        {
            var muze = _muzeRepository.Get(x => x.MuzeID == id);

            if (muze != null)
            {
                _muzeRepository.Delete(muze);
            }
        }

        public Muze GetById(Guid id)
        {
            return _muzeRepository.Get(x => x.MuzeID == id);
        }

        public List<Muze> GetAll()
        {
            return _muzeRepository.GetAll();
        }

        public void Update(Muze muze)
        {
            _muzeRepository.Update(muze);
        }
    }
}