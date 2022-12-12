using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ogrenciAdi = string.Empty;
            string ogrenciSoyadi= string.Empty;
            decimal not1 = 0;
            decimal not2 = 0;
            decimal not3 = 0;
            decimal ortalma = 0;

            Console.WriteLine("Merhaba ortalamasını hesaplamak istediğiniz öğrencinin bilgilerini giriniz");
            Console.Write("Ad : ");
            ogrenciAdi= Console.ReadLine();

            Console.Write("Soyad : ");
            ogrenciSoyadi= Console.ReadLine();

            Console.Write("Not1 : ");
            not1=Convert.ToDecimal(Console.ReadLine());

            Console.Write("Not2 : ");
            not2= Convert.ToDecimal(Console.ReadLine());

            Console.Write("Not3 : ");
            not3= Convert.ToDecimal(Console.ReadLine());

            ogrenci o = new ogrenci();

            o.ogrenciNotHesapla(ogrenciAdi, ogrenciSoyadi,not1, not2,not3);

        }
    }
}
