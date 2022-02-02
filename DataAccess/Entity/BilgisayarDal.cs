using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entity
{
    public class BilgisayarDal : IBilgisayarDal
    {
        List<Bilgisayar> _bilgisayars = new List<Bilgisayar>();
        public void Kaydet(Bilgisayar entity)
        {
            _bilgisayars.Add(entity);
        }

        public List<Bilgisayar> Siralama()
        {
            return _bilgisayars;
        }
    }
}
