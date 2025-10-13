using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktek_4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan nilai kamu : ");
            int nilai = int.Parse(Console.ReadLine());

            if (nilai >= 75)
            {
                Console.WriteLine("kamu lulus");
            }
            else
            {
                Console.WriteLine("kamu tidak lulus");
            }
        }
    }
}
