using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entity
{
    public class DizustuDal : IDizustuDal
    {
        List<Dizustu> _dizustus = new List<Dizustu>();
        public void Kaydet(Dizustu entity)
        {
            _dizustus.Add(entity);
        }

        public List<Dizustu> Siralama()
        {
            return _dizustus;
        }
    }
}
