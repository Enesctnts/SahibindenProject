using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Bilgisayar:Ilan,IEntity
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Bellek { get; set; }
        public string Islemci { get; set; }
        public short HDD { get; set; }
        public short SSD { get; set; }
        public bool EthernetVarMi { get; set; }
        public bool WifiVarMi { get; set; }

    }
}
