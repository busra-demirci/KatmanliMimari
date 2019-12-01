using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Entity
{
    public abstract class Base
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string AdSoyad { get { return Ad + " " + Soyad; } }
    }
}
