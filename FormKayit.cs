using System;
using System.Collections.Generic;
using System.Windows.Forms;
// Bir datagrid nesnesine liste elemanları yazılarak kütüphane kayıt otomasyonu yapan
// programdır. Programda Veri tabanı kullanmadan BindingSource ile liste kullanılmıştır. 
// kitaplar isimli bir liste değişkenine Kitap sınıfında bir liste bağlanmıştır.
// 
namespace Kutuphane.Otomasyonu
{
    public partial class FormKayit : Form
    {
        private int sayac = 1;
        private List<Kitap> kitaplar;
        private BindingSource bsKitaplar;

        public FormKayit()
        {
            InitializeComponent(); // Formun design bölümündeki bütün özellikleri oluşturuluyor.
            kitaplar = new List<Kitap>(); // kitaplar isminde Kitap sınıfında elemanları olan bir liste...
            bsKitaplar = new BindingSource
            {
                DataSource = kitaplar // Datagrid için Veri Kaynağı kitaplara eşitleniyor.
            };
            dgvKitaplar.DataSource = bsKitaplar;// Datagridin verileri bsKitaplar isimli bindingsource ile eşitleniyor
            dgvKitaplar.AutoGenerateColumns = false;// Columns sütun alanlarını el ile tanımlayabilmek için false tanımlandı.
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kaydet butonuna tıklandığında Kitap sınıfında kitap isimli bir nesne oluşuyor.
            // Bu nesnenin herbir özelliği Text kutularına yazılan değere eşitleniyor.
            var kitap = new Kitap
            {
                Id = sayac,
                KitapAdi = txtKitapAdi.Text,
                Yazar = txtYazar.Text,
                YayinEvi = txtYayinEvi.Text,
                Raf = txtRaf.Text,
                Tur = txtTur.Text
            };
            //Aşağıda Kitap Adı, Yazarı ve Yayınevi boş olup olmadığı kontrol ediliyor.
            if (!string.IsNullOrEmpty(kitap.KitapAdi)&& !string.IsNullOrEmpty(kitap.Yazar)&& !string.IsNullOrEmpty(kitap.YayinEvi))
            {
                bsKitaplar.Add(kitap);
                // 3 Alana ait text kutusu dolu ise yukarıda tanımlanan Kitap sınıfında bir elemanı bsKitaplar
                // bsKitaplar isimli BindingSource verisine kaydediliyor.
                // Sadece önemli 3 alanın boş olması ile yetindim.
                sayac++;// Id için  değer artırımı yapılıyor.
                FormTemizle();// Kayıt arkasından form temizleniyor.
            }
        }

        private void FormTemizle()
        {
            // Formun bütün içerikleri string.Empty ile temizleniyor.
            txtKitapAdi.Text = string.Empty;
            txtYazar.Text = string.Empty;
            txtYayinEvi.Text = string.Empty;
            txtRaf.Text = string.Empty;
            txtTur.Text = string.Empty;
        }
    }
}
