﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hatvany_Faktorialis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("adj értéket");
            int szam = int.Parse(Console.ReadLine());
            int hatvany_szam = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(szam, hatvany_szam));
            int result = szam;
            for (int i = 1; i < szam; i++)
            {
                result = result * i;
            }
            Console.WriteLine("Faktoriális: " + result);
            Console.ReadLine();


        }
    }
}
