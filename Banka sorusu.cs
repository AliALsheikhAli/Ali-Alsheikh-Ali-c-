using System;
using System.Data;

namespace ali170304106
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write("\n" + i + " x " + j + " = " + i * j);
                }
                Console.WriteLine("\t");
            }
            
           
        }
        Console.ReadLine();
    }
}
