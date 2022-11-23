using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter your marks");
            String marks = Console.ReadLine();



            switch (marks)
            {
                case "marks >= 0 & marks <= 39":
                    Console.WriteLine("Your grade is a F");
                    break;
                case "marks >= 40 & marks <= 49":
                    Console.WriteLine("Your grade is a D");
                    break;
                case "marks >= 50 & marks <= 59":
                    Console.WriteLine("Your grade is a C");
                    break;
                case "marks >= 60 & marks <= 69":
                    Console.WriteLine("Your grade is a B");
                    break;
                case "marks >= 70 & marks <= 100":
                    Console.WriteLine("Your grade is a A");
                    break;

            }

            Console.ReadKey();
        }
    }             

}
        
    

