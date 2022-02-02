using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entity
{
    public class KategoriDal : IKategoriDal
    {
        List<Kategori> _kategoriDals;

        public KategoriDal()
        {
            _kategoriDals = new List<Kategori>()
            {
                new Kategori{ Id=1 ,CategoryName= "Masa Üstü"},
                new Kategori{ Id=2 ,CategoryName= "Diz Üstü"},
                new Kategori{ Id=3 ,CategoryName= "Temizlik Ürünleri"},

            };
        }
        public void Kaydet(Kategori entity)
        {
            _kategoriDals.Add(entity);
        }

        public List<Kategori> Siralama()
        {
            return _kategoriDals;
        }
    }
}
