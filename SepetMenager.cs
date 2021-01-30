using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetMenager
    {
        //nameing convention
        //syntax
        public void Ekle(Product product)//parantez varsa metod çalışıyor
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: "+ product.Adi);

        }

        public void Ekle2(string productAdi, string aciklama, double fiyat, int StokAdedi)//parantez varsa metod çalışıyor
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + productAdi);

        }
    }
}
