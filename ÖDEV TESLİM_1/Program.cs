namespace ÖDEV_TESLİM_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //HAFTA_1 ÖDEV TESLİMİ

            //SORU_1 
            //Fiyat girin: /Kar oranı girin: /Satış fiyatınız:
            //Ekranda kullanıcıdan fiyat ve kar oranını belirleyip satış fiyatını hesaplayınız.

            Console.Write("Fiyatını girin : ");
            double fiyat = double.Parse(Console.ReadLine());

            Console.Write("Kar oranını girin : ");
            double kar = double.Parse(Console.ReadLine());

            double satis = fiyat + (fiyat * (kar / 100));
            Console.WriteLine("Satış fiyatı : " + satis );

            //SORU_2
            //Bir dikdörtgene ait olan kenar uzunluklarını isteyip alan ve çevre değerlerini döndüren kodunu yazın.

            Console.WriteLine("Alanı ve çevresi hesaplanacak olan dikdörtgen için:");

            Console.Write("Kısa kenar: ");
            int kk = int.Parse(Console.ReadLine());

            Console.Write("Uzun kenar: ");
            int uk = int.Parse(Console.ReadLine());

            int alan = kk * uk;
            Console.WriteLine("Alan: " + alan );

            int cevre = 2 * (kk + uk);
            Console.WriteLine("Çevre: " + cevre );

            //SORU_3 
            //Birim fiyatını ve adediğini kullanıcıdan alıp toplam tutarı hesapla

            Console.Write("Birim Fiyatı: ");
            int birim = int.Parse(Console.ReadLine());

            Console.Write("Adet: ");
            int adet = int.Parse(Console.ReadLine());

            int tutar = birim * adet;
            Console.WriteLine("Toplam tutar: " + tutar);


            //SORU_4
            //Girilen sayının karesini bul

            Console.Write("Sayı: ");
            int sayi = int.Parse(Console.ReadLine());

            int karesi = sayi * sayi;
            Console.WriteLine("Karesi: " + karesi);

            //SORU_5
            //Kullanıcının girdiği x ve y değerini alarak iki kare farkını hesaplayan kodu yazın.

            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());

            int fark = (x * x) - (y * y);
            if (fark >= 0)
            {
                 fark = fark;
            }
            else
            {
                fark = fark * -1;
            }
          
            Console.WriteLine("X ve Y değerlerinin kareleri farkı: " + fark);

            //SORU_6
            //Klavyeden girilen a,b ve c değerleri için 2b - 4ac denkleminin sonucunu bula kod yazınız.

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            int islem = (2 * b) - (4 * a * c);
            Console.WriteLine("2b - 4ac = " + islem);

            //SORU_7
            //Doğum yılını isteyen ve bu kişinin yaşını hesaplayıp, eğer kişi 17 yaşından büyükse ehliyet alabileceğini, küçükse alamayacağını söyleyen kod yazınız.

            Console.Write("Doğum yılı: ");
            int dogum = int.Parse(Console.ReadLine());

            int yas = 2024 - dogum;

            if (yas >= 18)
            {
                Console.WriteLine("Ehliyet alabilir.");
            }
            else if (yas >0 && yas < 18)
            {
                Console.WriteLine("Ehliyet alamaz.");
            }
            else
            {
                Console.WriteLine("Hatalı giriş");
            }




        }
    }
}
