using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_NOT_ORTALAMA_HESAPLAMA_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int not1,not2,ort;

            Console.WriteLine("I.Notunuzu Girin:");
            not1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("II.Notunuzu Girin:");
            not2=Convert.ToInt32(Console.ReadLine());

            ort = (not1+not2)/2;

            //Geçti Kaldı işlemi

            if (ort < 50)
            {
                Console.WriteLine("Kaldı");
            }
            else if(ort >=50 && ort <=100)
            {
                Console.WriteLine("Geçti");
            }

            Console.WriteLine("Ortalama:"+ort);

            Console.WriteLine("Çıkmak için bir tuşa basınız!");
            Console.ReadKey();
        }
    }
}
