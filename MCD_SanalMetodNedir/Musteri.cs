using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SanalMetodNedir
{
    public class Musteri // : Object => Framework standart olarak tüm nesneleri object'ten türetir.
    {
        public int musteriId { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }

        public override string ToString()
        {
            return isim + "\t" + soyisim;
        }
    }
}
