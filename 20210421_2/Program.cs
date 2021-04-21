using System;

namespace _20210421_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int inputN1 = int.Parse(input1);
            int inputN2 = int.Parse(input2);

            Console.WriteLine(inputN1 + "*" + inputN2 + "=" + (inputN1 * inputN2));

        }
    }
}
