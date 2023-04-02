using System;

namespace MyFirstProgram2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;

            int temp = n;
            while (temp != 0)
            {
                int c = temp % 10;
                i = i * 10 + c;
                temp = temp / 10;
            }

            if (n == i)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Nu e palindrom");
            }
        }
    }//Scrieti un program care va determina daca un numar este sau nu palindrom

}
