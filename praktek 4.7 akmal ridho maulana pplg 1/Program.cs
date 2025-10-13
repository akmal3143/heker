using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktek_4._7_akmal_ridho_maulana_pplg_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan nilai : ");
            int nilai = int .Parse(Console.ReadLine());

            if (nilai >= 90)
            {
                Console.WriteLine("predikat A");

            }
            else if (nilai >= 75)
            {
                Console.WriteLine("predikat B");
            }
            else if (nilai >= 60)
            {
                Console.WriteLine("peredikat C");
            }
            else
            {
                Console.WriteLine("predikat D");
            }
        }
    }
}
