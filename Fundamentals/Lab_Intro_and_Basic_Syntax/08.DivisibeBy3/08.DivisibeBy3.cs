﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Divisible_by_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <=100; i+=3) 
            {
                if (i%3 == 0)
                {
                    Console.WriteLine(i); 
                }
            }
        }
    }
}
