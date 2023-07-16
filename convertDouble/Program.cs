using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen ondalıklı sayıyı ekrana yazdıran kod bloğu
            double sayi;
            Console.WriteLine("Lütfen ondalıklı bir sayi giriniz : ");
            Console.WriteLine();
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Girmis oldugunuz ondalıklı sayi : " + sayi);

            Console.Read();
        }
    }
}
