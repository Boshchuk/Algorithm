using System;
using System.Collections.Generic;

namespace Alg1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sizeX = 5;
            const int sizeY = 3;

            var arr = new int [sizeY,sizeX];

            var iter = 0;

            for (int i = 0; i < sizeY; i++)
            {
                for (int j = 0; j < sizeX; j++)
                {
                    arr[i, j] = iter++;
                }
            }

            for (int i = 0; i < sizeY; i++)
            {
                for (int j = 0; j < sizeX; j++)
                {
                    Console.Write(string.Format("{0} ", arr[i, j]));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            var t = 0;
            var list = new List<int>();
                for (var y =sizeY -1; y >=0; y--)
                {
                    for (var x = t; x < sizeX; x++)
                    {
                        for (var n = 0; n <sizeY ; n ++)
                        {
                            if (y - n < 0 || x - n < 0)
                            {
                                break;
                            }
                            Console.Write(string.Format("{0} ", arr[y - n, x - n]));
                            list.Add(arr[y - n, x - n]);
                        }
                        t = x;
                    }
                }

            Console.ReadKey();
        }
    }
}
