using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Dizustu : Bilgisayar, IEntity
    {
        public int Id { get; set; }
        public string EkranBoyutu { get; set; }
        public float Agirlik { get; set; }
        
    }
}
