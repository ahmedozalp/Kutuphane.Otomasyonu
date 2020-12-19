using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Otomasyonu
{
    class Kisi
    {
        public int tckimlikno;
        public string kutuphane_id;
        public string adi;
        public string soyadi;
        public string telefon;
        public string eposta;
        public string adres;
        public Kisi(int _tckimlikno, string _kutuphane_id, string _adi, string _soyadi,
        string _telefon, string _eposta, string _adres)
        {
            tckimlikno = _tckimlikno;
            kutuphane_id = _kutuphane_id;
            adi = _adi;
            soyadi = _soyadi;
            telefon = _telefon;
            eposta = _eposta;
            adres = _adres;
        }

    }
}
