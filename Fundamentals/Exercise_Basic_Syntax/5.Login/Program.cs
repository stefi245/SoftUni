﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            int attempts = 0;
            while (attempts < 4)
            {
                string inputPassword = Console.ReadLine();
                attempts++;
                if (inputPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break; 
                }
                else if (attempts == 4)
                {
                    Console.WriteLine($"User {username} blocked!");

                }
                else if (inputPassword != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
              
            }
        }
    }
}
