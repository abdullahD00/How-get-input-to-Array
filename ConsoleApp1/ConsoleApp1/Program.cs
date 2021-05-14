using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int satır, sütün;

            Console.Write("satır sayısını giriniz:");
            satır = Convert.ToInt32(Console.ReadLine());

            Console.Write("sütün sayısını giriniz:");
            sütün = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] matris = new int[satır, sütün];

            for(int i = 0; i < satır; i++)
            {
                for(int j=0; j < sütün; j++)
                {
                    Console.Write("dizinin {0}*{1} deki değerini giriniz;", i + 1, j + 1);
                    matris[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }


            for(int i = 0; i < satır; i++)
            {
                for(int j = 0; j < sütün; j++)
                {
                    Console.Write(" {0} ", matris[i, j]);
                    Console.WriteLine();
                }
            }









            Console.Read();

        }
    }
}
