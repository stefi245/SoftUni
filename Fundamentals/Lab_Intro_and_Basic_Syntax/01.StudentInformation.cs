using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabIntroAndBasicSyntax
{
    //"Name: {student name}, Age: {student age}, Grade: {student grade}".
    internal class Program
    {
        static void Main(string[] args)
        { 
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {averageGrade:f2}");

        }
    }
}
