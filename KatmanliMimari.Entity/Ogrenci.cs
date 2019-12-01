using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Entity
{
    public class Ogrenci : Base
    {
        public string Bolum { get; set; }

        public int NotHesapla()
        {
            return 50;
        }
    }
}
