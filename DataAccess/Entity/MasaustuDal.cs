using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entity
{
    public class MasaustuDal : IMasaustuDal
    {
        List<Masaustu> _masaustus = new List<Masaustu>();
        public void Kaydet(Masaustu entity)
        {
            _masaustus.Add(entity);
        }

        public List<Masaustu> Siralama()
        {
            return _masaustus;
        }
    }
}
