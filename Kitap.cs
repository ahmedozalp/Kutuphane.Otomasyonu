using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Otomasyonu
{
    //c# özelliği ile property tanımlaması ile yetiniliyor.
    class Kitap
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string YayinEvi { get; set; }
        public string Tur { get; set; }
        public string Raf { get; set; }
    }
}

