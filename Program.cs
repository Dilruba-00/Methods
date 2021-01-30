using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elmasi";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakir karpuzu";

            Product[] products = new Product[] {product1 ,product2 };

            //type-safe -- tip güvenligi
            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("------------Methods------------");

            //instance - örnek
            //encapsulation

            SepetMenager sepetManager = new SepetMenager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);


            sepetManager.Ekle2("Armut", "Yesil Armut", 12 , 10);
            sepetManager.Ekle2("Elma", "Yesil elma", 12, 3);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 14);

        }
    }
}


