using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Masaustu: Bilgisayar, IEntity
    {
        public int Id { get; set; }
        public bool MonitorVarMi { get; set; }
        public KasaTipi KasaTipi { get; set; }



    }
}
