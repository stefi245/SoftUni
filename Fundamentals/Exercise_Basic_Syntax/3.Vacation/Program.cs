using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercise_Basic_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double priceForOnePerson = 0;
            double totalPrice = 0; 

            // Calculations 

            if (typeOfGroup == "Students")

            {
                if (dayOfWeek == "Friday")
                {
                    priceForOnePerson = 8.45; 
                }
                else if (dayOfWeek =="Saturday")
                {
                    priceForOnePerson = 9.80; 
                }
                else if (dayOfWeek == "Sunday")
                {
                    priceForOnePerson = 10.46; 
                }
                totalPrice = countOfPeople * priceForOnePerson;
                if (countOfPeople >= 30)
                {
                    totalPrice = totalPrice * 0.85; 
                }
            }

            else if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    priceForOnePerson = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceForOnePerson = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    priceForOnePerson = 16; ;
                }
                totalPrice = countOfPeople * priceForOnePerson;
                if (countOfPeople >= 100)
                {
                    totalPrice = (countOfPeople - 10) * priceForOnePerson; 
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    priceForOnePerson = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceForOnePerson = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    priceForOnePerson = 22.50;
                }
                totalPrice = countOfPeople * priceForOnePerson;
                if (countOfPeople >= 10 && countOfPeople <=20)
                {
                    totalPrice = totalPrice * 0.95; 
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
