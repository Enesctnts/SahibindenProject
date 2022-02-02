using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class IlanManager : IIlanService
    {
        private IIlanDal _ıILanDal;

        public IlanManager(IIlanDal ıILanDal)
        {
            _ıILanDal = ıILanDal;
        }

        public void Kaydet(Ilan entity)
        {
            _ıILanDal.Kaydet(entity);
        }

        public List<Ilan> Siralama()
        {
            return _ıILanDal.Siralama();
        }
    }
}
