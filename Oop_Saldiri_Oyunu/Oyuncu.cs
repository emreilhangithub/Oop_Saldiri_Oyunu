using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Saldiri_Oyunu
{
    class Oyuncu
    {
        //bu sınıfın neyi var
        public string OyuncuAdi { get; set; }
        public string OyuncuIrk { get; set; }
        public string OyuncuBrans { get; set; }
        public string OyuncuSilah { get; set; }
        public int SaldiriGucu { get; set; }
     
        //oyuncu ne yapabilir

        public void Saldir()
        {
            Random rnd = new Random();

            switch (OyuncuIrk)
            {
                case "Savaşçı": SaldiriGucu = rnd.Next(0, 11); break;
                case "Ninja": SaldiriGucu = rnd.Next(0, 12); break;
                case "Sura": SaldiriGucu = rnd.Next(0, 13); break;
                case "Şaman": SaldiriGucu = rnd.Next(0, 14); break;
                case "Lycan": SaldiriGucu = rnd.Next(0, 15); break;               
                default: break;
            }

            switch (OyuncuBrans)
            {
                case "Karabüyü": SaldiriGucu += rnd.Next(40,50); break;
                case "Ofansif": SaldiriGucu += rnd.Next(30,40); break;
                case "Defansif": SaldiriGucu += rnd.Next(20,30); break;
                default: break;
            }

            switch (OyuncuSilah)
            {
                case "Saldırı Tüfeği": SaldiriGucu += rnd.Next(60, 70); break;
                case "Nişancı Tüfeği": SaldiriGucu += rnd.Next(50, 60); break;
                case "Tabanca": SaldiriGucu += rnd.Next(10, 30); break;
                case "Hafif Makineli Tüfek": SaldiriGucu += rnd.Next(40, 50); break;
                case "Pompalı Tüfek": SaldiriGucu += rnd.Next(50, 60); break;
                case "Hafif Makineli Silah": SaldiriGucu += rnd.Next(55, 60); break;
                case "Keskin Nişancı Tüfeği": SaldiriGucu += rnd.Next(70, 90); break;
                default: break;
            }


        }

    }
}
