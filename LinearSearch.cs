using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen dizinin boyutunu girin: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Lütfen dizinin elemanlarını girin: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Dizi: [{0}]", string.Join(", ", array));

            Console.WriteLine("Lütfen aramak istediğiniz elemanı girin: ");
            int searchElement = Convert.ToInt32(Console.ReadLine());

            bool isFound = false;
            for (int i = 0; i < size; i++)
            {
                if (array[i] == searchElement)
                {
                    Console.WriteLine("Eleman {0} indeksinde bulundu.", i);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("Eleman dizide bulunamadı.");
            }



            Console.ReadKey();
        }
    }
}
