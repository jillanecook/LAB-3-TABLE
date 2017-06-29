using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            do

            {
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine("Enter an Integer: ");
                int.Parse(Console.ReadLine());
                Console.WriteLine("Number     Squared       Cubed");
                Console.WriteLine("========   =========     ========");
                for (int n = 1; n <= 10; n++)

                    
                Console.WriteLine("{0}             {1}             {2}",n,n*n,n*n*n);
                
            }
            while (Continue() == true);

        }
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("Does not compute!");
                run = Continue();

            }
            return run;
        }

    }
    }

