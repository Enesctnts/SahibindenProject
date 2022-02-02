using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    
    public class Ilan:IEntity
    {
        public int Id { get; set; }
        public long IlanNo { get; set; }
        public string Baslik { get; set; }
        public DateTime IlanTarihi { get; set; }
        public double Fiyat { get; set; }
        public Kullanici Satici { get; set; }
        public Kategori kategori { get; set; }
        


    }

}
