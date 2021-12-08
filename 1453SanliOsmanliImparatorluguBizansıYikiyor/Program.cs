using System;

namespace _1453SanliOsmanliImparatorluguBizansıYikiyor
{
    class Program
    {
        static void Main(string[] args)
        {
            SanliOsmanliImparatorlugu padisah1 = new SanliOsmanliImparatorlugu();
            padisah1.PadisahName = "Fatih Sultan Mehmet";
            padisah1.PadisahId = 8;
            Console.WriteLine("Bizansı yıkan padişahı görmek için 1453 yazın...");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 1453)
            {
                Console.WriteLine(padisah1.PadisahName +"Bizansı Yıkmıştır");
            }
            else
            {
                Console.WriteLine("Vatan haini");
            }
        }
        public class Bizans
        {
            public int AskerSayisi { get; set; }
            public int YuzOlcumu { get; set; }
        }
        public class SanliOsmanliImparatorlugu
        {
            public int PadisahId { get; set; }
            public string PadisahName { get; set; }

        }
    }
}
