using System;

namespace HESAP_MAKİNESİ
{
    class Program
    {
        static void Main(string[] args)
        {
            char cikis;
            char secimChar;

            do
            {
                Console.Clear();
                int sonuc = 0;

                Console.WriteLine("Toplama İşlemi İçin +");
                Console.WriteLine("Çıkarma İşlemi İçin -");
                Console.WriteLine("Çarpma İşlemi İçin *");
                Console.WriteLine("Bölme İşlemi İçin /");
                Console.Write("Yapmak İstediğiniz İşlemi Seçin : ");
                string secim=Console.ReadLine();

                Console.Write("1.Değeri Girin :");
                int sayi1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("2.Değeri Girin:");
                int sayi2 = Convert.ToInt16(Console.ReadLine());

                secimChar = Convert.ToChar(secim);
                switch (secimChar)
                {
                    case '+':
                        sonuc = sayi1 + sayi2;
                        Console.WriteLine("Toplama İşleminin Sonucu : {0}", sonuc);
                        break;
                    case '-':
                        sonuc = sayi1 - sayi2;
                        Console.WriteLine("Çıkarma İşleminin Sonucu : {0}", sonuc);
                        break;
                    case '*':
                        sonuc = sayi1 * sayi2;
                        Console.WriteLine("Çarpma İşleminin Sonucu : {0}", sonuc);
                        break;
                    case '/':
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine("Çıkarma İşleminin Sonucu : {0}", sonuc);
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim Yaptınız");
                        break;
                }
                Console.WriteLine("Başka İşlem Yapacakmısınız?(E/H)");
                cikis = Convert.ToChar(Console.ReadLine());

            } while (cikis != 'h');
        }
    }
}
