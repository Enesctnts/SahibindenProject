using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entity
{
    public class KasaTipiDal : IKasaTipiDal
    {
        List<KasaTipi> _kasaTipis;
        public KasaTipiDal()
        {
            _kasaTipis = new List<KasaTipi>
            {
                new KasaTipi{ Id =1 ,KasaAd= "Dikey"},
                new KasaTipi{ Id =1 ,KasaAd= "Yatay"},
                new KasaTipi{ Id =1 ,KasaAd= "Thin Client"}

            };
        }
        public void Kaydet(KasaTipi entity)
        {
            _kasaTipis.Add(entity);
        }

        public List<KasaTipi> Siralama()
        {
            return _kasaTipis;
        }
    }
}
