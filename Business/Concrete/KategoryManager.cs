using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KategoryManager : IKategoryService
    {
        private IKategoriDal _kategoryDal;

        public KategoryManager(IKategoriDal kategoryDal)
        {
            _kategoryDal = kategoryDal;
        }

        public void Kaydet(Kategori entity)
        {
            _kategoryDal.Kaydet(entity);
        }

        public List<Kategori> Siralama()
        {
            return _kategoryDal.Siralama();
        }
    }
}
