using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine();
            TableGen();
        }

        private static void TableGen()
    {
            bool again = true;
            int inputNum;
            List<int> numbers = new List<int>();
            string answer;
        while (again)
        {
            Console.WriteLine("Please enter an integer.");
            inputNum = int.Parse(Console.ReadLine());
            Console.WriteLine();

            numbers = NumberList(inputNum);

            Console.WriteLine("{0, -8} {1, -8} {2, 0}", "Number", "Squared", "Cubed");
            Console.WriteLine("{0, -8} {1, -8} {2, 0}", "======", "=======", "=====");

            foreach (int i in numbers)
            {
                Console.WriteLine("{0, -8} {1, -8} {2, 0}", (i), (i * i), (i * i * i));
            }

            Console.WriteLine();
            Console.WriteLine("Would you like to try again? (Y/N)");
            answer = Console.ReadLine();

            if (answer != "Y" && answer != "y")
            {
                again = false;
            }
            Console.WriteLine();
        }
    }
        

        private static List<int> NumberList(int number)
        {
            List<int> numbList = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                numbList.Add(i);
            }
            return numbList;
        }
    }
}
