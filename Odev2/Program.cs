namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console'dan alınan ay'ın mevsimini yazdıran prorgramı yapınız.
            Console.WriteLine("Lütfen ay giriniz");
            string ay = Console.ReadLine();




            // eğer ay;  aralık-ocak-şubat      girilirse ekrana KIŞ 
            // mart-nisan-mayıs       girilirse ekrana İLK BAHAR
            // haziran-temmuz-ağustos girilirse ekrana YAZ 
            // eylük-ekim-kasım       girilirse ekrana SON BAHAR
            // mesajlarını veren programı yazınız.. Girilen ay için kaçıncı ay olduunu yazınız ekrana n. Ay şeklinde yazınız..

            // örnek;
            // klavyeden girilen ocak ayı için çıktı aşağıdaki gibi olmalıdır;
            // KIŞ
            // 1. Ay


            // todo: bütün  istenilenleri switch-case ve if karar mekanizmaları kullanarak yapınız


            switch (ay)
            {
                case ("ocak"):
                    Console.WriteLine("KIŞ");
                    Console.WriteLine("1.AY");

                    break;

                case ("şubat"):
                    Console.WriteLine("KIŞ");
                    Console.WriteLine("2.AY");

                    break;

                case ("mart"):
                    Console.WriteLine("İLKBAHAR");
                    Console.WriteLine("3.AY");

                    break;

                case ("nisan"):
                    Console.WriteLine("İLKBAHAR");
                    Console.WriteLine("4.AY");

                    break;

                case ("mayıs"):
                    Console.WriteLine("İLKBAHAR");
                    Console.WriteLine("5.AY");

                    break;

                case ("haziran"):
                    Console.WriteLine("YAZ");
                    Console.WriteLine("6.AY");

                    break;

                case ("temmuz"):
                    Console.WriteLine("YAZ");
                    Console.WriteLine("7.AY");

                    break;

                case ("agustos"):
                    Console.WriteLine("YAZ");
                    Console.WriteLine("8.AY");

                    break;

                case ("eylül"):
                    Console.WriteLine("SONBAHAR");
                    Console.WriteLine("9.AY");

                    break;

                case ("ekim"):
                    Console.WriteLine("SONBAHAR");
                    Console.WriteLine("10.AY");

                    break;

                case ("kasım"):
                    Console.WriteLine("SONBAHAR");
                    Console.WriteLine("11.AY");

                    break;

                case ("aralık"):
                    Console.WriteLine("KIŞ");
                    Console.WriteLine("12.AY");

                    break;

                default:
                    Console.WriteLine("!! ÖYLE BİR AY YOK !!");
                    break;





            }
            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadLine();


        }
    }
}