using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entity
{
    public class IlanDal : IIlanDal
    {
        List<Ilan> _ilans = new List<Ilan>();

        public void Kaydet(Ilan entity)
        {
            _ilans.Add(entity);
        }


        public List<Ilan> Siralama()
        {
            return _ilans;
        }
    }
}
