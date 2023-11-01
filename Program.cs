
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            // Müziği çalma
            SoundPlayer ses = new SoundPlayer();
            string yol;
            yol = "C:\\Users\\Eren\\Desktop\\ismail_yk_oha_official_video_mp3_58506.wav";
            ses.SoundLocation = yol;
            ses.Play();
            Console.Title = "VKE Hesaplama Programı\n";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Vücut Kitle Endeksi Hesaplayıcı");

            Console.Write("Lütfen kilonuzu (kg cinsinden) girin: ");
            double kilo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lütfen boyunuzu (cm cinsinden) girin: ");
            double boyCM = Convert.ToDouble(Console.ReadLine()) / 100;

            double vucutKitleEndeksi = kilo / (boyCM * boyCM);
            Console.WriteLine("Vücut Kitle Endeksiniz: " + vucutKitleEndeksi.ToString("0.00"));

            string durum = DurumuGetir(vucutKitleEndeksi);
            Console.WriteLine("Durumunuz: " + durum);

            Console.WriteLine("Başka bir hesaplama yapmak ister misiniz? (Evet/Hayır)");
            string cevap = Console.ReadLine();

            if (cevap.ToLower() != "evet")
            {
                break;
            }
        }

       
    }

    static string DurumuGetir(double vucutKitleEndeksi)
    {
        if (vucutKitleEndeksi < 18.5)
        {
            return "Zayıf";
        }
        else if (vucutKitleEndeksi >= 18.5 && vucutKitleEndeksi < 24.9)
        {
            return "Normal";
        }
        else if (vucutKitleEndeksi >= 25 && vucutKitleEndeksi < 29.9)
        {
            return "Fazla Kilolu";
        }
        else
        {
            return "Obez";
        }
    }
}
