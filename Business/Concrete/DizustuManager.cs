using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DizustuManager : IDizustuService
    {
        private IDizustuDal _dizustuDal;
        private IKategoryService _kategoryService;

        public DizustuManager(IDizustuDal dizustuDal, IKategoryService kategoryService)
        {
            _dizustuDal = dizustuDal;
            _kategoryService = kategoryService;
        }


        public void Kaydet(Dizustu entity)
        {
            _dizustuDal.Kaydet(entity);
        }

        public List<Dizustu> Siralama()
        {
            return _dizustuDal.Siralama();
        }

        public Kategori KategoriBul(int id)
        {
            foreach (var item in _kategoryService.Siralama())
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
