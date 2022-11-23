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

            Console.WriteLine("Enter your grade for your Mathmatics Final Exam");
         
            string input = Console.ReadLine();
            char marks = input.ToCharArray()[0];
            
            

            //D marks >= 0 & marks <= 49 C marks >= 0 & marks <= 59" B marks >= 0 & marks <= 69  
            switch (char.ToUpper(marks))
            {
                case 'A' :
                    Console.WriteLine("Your grade is a 70 to 100.");
                    break;
                case 'B':
                    Console.WriteLine("Your grade is a 60 to 69.");
                    break;
                case 'C':
                    Console.WriteLine("Your grade is a 50 to 59.");
                    break;
                case 'D':
                    Console.WriteLine("Your grade is a 40 to 49.");
                    break;
                case 'F':
                    Console.WriteLine("Your grade is 39 to 0.");
                    break;
                default :
                    Console.WriteLine("Not a correct value for marks");
                    break;

            }

            Console.ReadKey();
        }
    }             

}
        
    

