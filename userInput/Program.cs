﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace userInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Hello " + name + " you are " + age);

            Console.ReadLine();
           

            

            
        }
    }
}
