using System;

namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
         
            
            
            DateTime dt = DateTime.Now;

            string ad = "Hande";
            string soyad = "Yazkan";
            string ad_soyad = ad + " " + soyad;

            int i1 = 5;
            int i2 = 3;
            int i3 = i1 * i2;

            bool bo1 = 10<2;

            // değişken dönüşümleri
            string str1 = "20";
            int int1 = 21;

            string yeniDeger = str1 + int1.ToString();
            
            int int41 = int1 + Convert.ToInt32(str1);

            string dtm = DateTime.Now.ToString("dd.MM.yyyy");

            string hour = DateTime.Now.ToString("HH:mm");
           

            
            Console.WriteLine(dtm);
            Console.WriteLine(hour);
           
          
        }
    }
}
