using System;
 
namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, limit, f1 = 0, f2 = 1, f3 = 0;
            Console.Write("Enter the Limit : ");
            limit = double.Parse(Console.ReadLine());
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i <= limit; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
            Console.ReadLine();

        }
    }
}
