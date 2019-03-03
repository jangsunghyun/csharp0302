//2. 아래와 같은 결과를 만들기 위해 괄호를 채우세요.
//[결과]
//12345678
//12345678
using System;
using System.Collections.Generic;
namespace ConsoleApplication17
{

    class Program
    {
        //static void ArrDisplay(int[,] arr)
        //{
        //    foreach (int j in arr)
        //    {
        //        Console.WriteLine(j);
        //    }
        //}

        static void Main(string[] args)
        {
            //----4행2열
            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            //ArrDisplay(twoDim);

            for (int j = 0; j < twoDim.GetLength(0); j++ )
            {                
                for (int k = 0; k < twoDim.GetLength(1); k++)
                {                    
                    Console.Write(twoDim[j, k]);
                }
            }
            Console.WriteLine();
            foreach (int i in twoDim)
            {

                Console.Write(i);
            }
        }
    }
}