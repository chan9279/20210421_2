using System;

namespace _20210421_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int random1 = random.Next(2,10);
            int random2 = random.Next(2 ,10);
            Console.WriteLine(random1 + "X" + random2 +" = ?");
            string input = Console.ReadLine();
            int inputN3 = int.Parse(input);
            if((random1 * random2) == inputN3)
            {
                Console.WriteLine("정답입니다. ");
            }
            else
            {
                Console.WriteLine("틀렸습니다. ");
            }

        }
    }
}
