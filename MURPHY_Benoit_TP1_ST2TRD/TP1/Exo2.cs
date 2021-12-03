using System;

namespace TP1
{
    public class Exo2
    {
        public void ex2()
        {
            Console.WriteLine("Choose between: \n 1. Prime number between 1 and 1000" +
                              "\n 2. Fibonacci Sequence " +
                              "\n 3. Factorial number ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Prime();
                    break;
                case 2:
                    Fibo();
                    break;
                case 3:
                    Fact();
                    break;
                default:
                    Console.WriteLine("Error, pick a number between 1 and 3");
                    break;
            }

        }
        public void Prime()
        {
            bool a;
            for (int i = 2; i <= 1000; i++)
            {
                a = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        a = false;
                        break;
                    }
                }
                if (a == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Fibo()
        {
            Console.WriteLine("Please write a number and press enter : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            int y = 1;
            int z = 0;
            if (n == 0 || n == 1)
            {
                Console.WriteLine("F("+n+")= " + n);
            }
            for (int i = 2; i <= n; i++)
            {
                x = y + z;
                z = y;
                y = x;

            }
            Console.WriteLine("F("+n+")= " + x);
        }

        public void Fact()
        {
            Console.WriteLine("Please write a number and press enter : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            if (n == 0 || n == 1)
            {
                Console.WriteLine(n+"!= " + 1);
            }
            for (int i = 2; i <= n; i++)
            {
                x = x * i;
            }

            Console.WriteLine(n + "!= " + x);

        }
    }
}