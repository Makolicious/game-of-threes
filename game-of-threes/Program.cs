using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_of_threes
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Enter a number.");
            string userInput = Console.ReadLine();
            int subjectNum;

            try
            {
                subjectNum = Int32.Parse(userInput);
                Console.WriteLine(subjectNum);
                while (subjectNum != 1)
                {
                    if (subjectNum % 3 == 0)
                    {
                        Console.WriteLine(subjectNum + " 0");
                        subjectNum = subjectNum / 3;
                    }

                    else if ((subjectNum + 1) % 3 == 0)
                    {
                        Console.WriteLine(subjectNum + " +1");
                        subjectNum = (subjectNum + 1) / 3;
                    }

                    else if ((subjectNum - 1) % 3 == 0)
                    {
                        Console.WriteLine(subjectNum + " -1");
                        subjectNum = (subjectNum - 1) / 3;
                    }
                }
                Console.WriteLine(subjectNum);
                Console.WriteLine("Finished!");
                goto start;
            }
            catch
            {
                Console.WriteLine("Please enter a valid number.");
                goto start;
            }
        }
    }
}

