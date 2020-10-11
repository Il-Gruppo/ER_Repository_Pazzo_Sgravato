using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayVettore
{
    class Program
    {
        static void Main(string[] args)
        {
            //dato un array, controllare se il vettore è in ordine crescente

            int[] myArray = { 1, 0, 5, -6, 9 };
            int cont = 0;
            int cont2 = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                cont2 = myArray[i];
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[i] > cont)
                    {
                        //Console.WriteLine(cont2);
                        Console.WriteLine("ordine crescente");
                    }
                    else
                    {
                        Console.WriteLine("ordine non crescente");
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
